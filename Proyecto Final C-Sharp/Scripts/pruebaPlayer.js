$(function () {
    // globals
    // player URL
    var url = "";
    // player video id
    var videoId = "";
    // player iframe
    const $iframe = $("iframe");
    // button to play YouTube video url entered
    //const $playButton = $(".btnPlay");
    var idsButtons = [];
    var idsUrls = [];

    var element = document.getElementById('MainContent_ChildContent2_podcastsVideos');
    var count = element.childElementCount;

    for (var i = 0; i < count; i++) {
        idsButtons[i] = $(`#play${i}`);
        idsUrls[i] = $(`#input-field${i}`);
    }

    // overlay that video player iframe is shown
    const $overlay = $("#overlay");
    // notification that shows errors and information
    const $notification = $("#notification");
    // loading text that displays when video is loading
    const $loader = $("#loader");
    // modal that shows all the availible shortcuts in the video player
    const $shortcutsModal = $("#shortcuts-modal");
    // url submission form
    const $form = $("form");
    // parent for button and video thumbnail that appear when a video is minimized
    const $expandBox = $("#expand-box");
    const $thumbnail = $("#thumbnail");
    // parent div of options dropdown
    const $optionsDiv = $("#options-div");
    // button that toggles private mode
    const $privateModeButton = $("#private-mode");
    // checks if the video is loaded or not
    var isLoaded = function () {
        return $iframe.readyState == "complete" || "interactive" ? true : false;
    };
    // determines if the video should be loaded with a YouTube privacy enhanced URL or a regular YouTube embed url
    var $privateMode = function () {
        return JSON.parse($("#private-mode").data("enabled"));
    };

    // regex
    // gets the youtube video id from strings
    // const urlDissector =
    // /(http(?: s) ?: \/\/(?:m.)?(?:www\.)?)?youtu(?:\.be\/|be\.com\/(?:watch\?(?:feature=youtu\.be\&)?v=|v\/|embed\/|shorts\/|user\/(?:[\w#]+\/)+))([^&#?\n]+)/gm
    // checks if the url is a valid youtube url and is something our player can play
    const urlDissector =
        /((http?(?:s)?:\/\/)?(www\.)?)?(?:youtu\.be\/|youtube\.com\/(?:embed\/|shorts\/|v\/|watch\?v=|watch\?(?:[^&?]*?=[^&?]*)&v=))((?:\w|-){11})((?:\&|\?)\S*)?/;

    // expression to test if there are any whitespaces in our url
    const whiteSpaceRE = /\s/g;

    const $inputField = $(".inputField");

    function getVideoURL() {
        url = $inputField.val();
        // checks if there is whitespace in the url, if there is, reassign the url to the string with the whitespace removed
        let hasWhiteSpace = whiteSpaceRE.test(url);
        url = hasWhiteSpace ? url.replace(/\s/g, "") : url;
        getId(url);
    }

    // gets youtube video id of given url
    // takes parameter url(string)
    function getId(url) {
        // strips the video id from our url
        videoId = urlDissector.exec(url)[4];
        if (
            $iframe.attr("src") !== undefined &&
            $iframe.attr("src").includes(videoId)
        ) {
            $expandBox.hide();
            $overlay.show();
        } else {
            loadVideo(videoId);
        }
        return videoId;
    }

    // loads the youtube video into the player iframe
    // take parameter videoId(string)
    function loadVideo(videoId) {
        $overlay.show();
        $expandBox.hide();
        $loader.show();
        if ($privateMode()) {
            // sets the video player iframe's url to a youtube privacy-enhanced url(video doesn't show up on user's youtube search history) if the user has enabled Privacy Mode
            $iframe.attr(
                "src",
                `https://www.youtube-nocookie.com/embed/${videoId}?autoplay=1&dnt=1`
            );
        } else {
            // sets the video player iframe's url to a youtube embed url (default)
            $iframe.attr(
                "src",
                `https://www.youtube.com/embed/${videoId}?autoplay=1`
            );
        }

        // focus iframe when it has loaded
        $iframe.onload = function () {
            $iframe.focus();
        };
    }

    // toggles fullscreen for the iframe
    function openFullscreen() {
        // puts the player in full screen mode
        var player = document.querySelector("iframe");
        if (player.src.length !== 0 && isLoaded()) {
            if (player.requestFullscreen) {
                player.requestFullscreen();
            } else if (player.webkitRequestFullscreen) {
                /* Safari */
                player.webkitRequestFullscreen();
            } else if (player.msRequestFullscreen) {
                /* IE11 */
                player.msRequestFullscreen();
            } else {
                alert("Unable to open video in full screen");
            }
        } 
    }

    // resets numerous things for the player
    function reset() {
        $iframe.attr("src", "");
        // expandButton.disabled = true;
        // document.querySelector("#private-mode").checked = false;
        $privateModeButton.data("enabled", false);
        $privateModeButton.attr(
            "title",
            "private mode is currently disabled(click to enable)"
        );
        $privateModeButton.css("background-color", "rgb(249, 249, 249)");
        clearNotification();
    }

    // opens youtube video in a window so the user can like, dislike a video, or subscribe to a youtube channel
    function openVideo() {
        if (isLoaded()) {
            // TODO: change to responsive size
            let w = 1000;
            let h = 900;
            let left = screen.width / 2 - w / 2;
            let top = screen.height / 2 - h / 2;
            window.open(
                "https://www.youtube.com/watch?v=" + videoId,
                document.title,
                "toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=no, resizable=no, copyhistory=no, width=" +
                w +
                ", height=" +
                h +
                ", top=" +
                top +
                ", left=" +
                left
            );
        }
    }

    // closes player video overlay
    function closeOverlay() {
        $overlay.hide();
        $expandBox.hide();
        $thumbnail.attr("src", "");
        reset();
    }

       // clears notification
    function clearNotification() {
        $notification.text("");
        $notification.removeClass();
    }

    // keyboard shortcuts event listener
    $(document).on("keydown", function (e) {
        e.preventDefault();
        if (e.key === "r" && $overlay.is(":visible")) {
            loadVideo(videoId);
        } else if (
            (e.key === "Escape" || e.key === "x") &&
            document.fullscreenElement === null &&
            $overlay.is(":visible")
        ) {
            minimizeOverlay();
            $inputField.select();
        } else if (
            e.key === "f" &&
            document.fullscreenElement === null &&
            $overlay.is(":visible")
        ) {
            openFullscreen();
        } else if ((e.key === "m" || e.key === "_") && $overlay.is(":visible")) {
            minimizeOverlay();
        } else if (
            (e.key === "o" || e.key === "+") &&
            $overlay.is(":hidden") &&
            $iframe.attr("src").length != 0
        ) {
            $overlay.show();
        } else if (e.key === "?") {
            if ($shortcutsModal.is(":hidden")) {
                $shortcutsModal.show();
            } else {
                $shortcutsModal.hide();
            }
        } else {
        }
    });

    // When the user clicks anywhere outside of the modal, close it
    window.onclick = (e) => {
        if (e.target == $shortcutsModal) {
            $shortcutsModal.hide();
        }
    };

    // hide the loader every time a video loads in the iframe
    $iframe.on("load", function (e) {
        $loader.hide();
    });

    // event listener that listens for successful form submissions
    // if the input field is submitted successfully, get the video url via the getVideoURL() function
    $("form").on("submit", function (e) {
        e.preventDefault();
        getVideoURL();
    });

    // show the overlay whe the user clicks on the video expand thumbnail
    $expandBox.on("click", function (e) {
        $overlay.show();
        // expandButton.disabled = "true";
        $expandBox.hide();
        $thumbnail.attr("src", "");
    });

    // option click handler
    $optionsDiv.on("click", function (e) {
        e.preventDefault();
        switch (e.target.id) {
            case "private-mode":
                if ($privateMode()) {
                    $privateModeButton.data("enabled", false);
                    $privateModeButton.attr(
                        "title",
                        "private mode is currently disabled(click to enable)"
                    );
                    $privateModeButton.css("background-color", "rgb(249, 249, 249)");
                } else {
                    $privateModeButton.data("enabled", true);
                    $privateModeButton.attr(
                        "title",
                        "private mode is currently enabled(click to disable)"
                    );
                    // document.querySelector("#private-mode").style.backgroundColor = "#68b723";
                    $privateModeButton.css("background-color", "lightgreen");
                }
                loadVideo(videoId);
                break;
            case "reload":
                loadVideo(videoId);
                break;
            case "open-video":
                if ($privateMode()) {
                    if (
                        confirm(
                            "Warning, this video is playing in private mode. If you open the video, it will show up as you viewing it and will not load if restricted mode is enabled for your YouTube account.\nDo you wish to still open the video?"
                        )
                    ) {
                        openVideo();
                    }
                } else {
                    openVideo();
                }
                break;
            default:
                console.error("error: unknown button clicked in options dropdown");
        }
    });

    for (var i = 0; i < idsButtons.length; i++) {
        idsButtons[i].on("click", function (e) {
            $form.submit();
        });
    }

    // overlay close overlay button
    $("button:contains('close')").on("click", function (e) {
        e.preventDefault();
        closeOverlay();
    });

    // overlay fullscreen button
    $("button:contains('check_box_outline_blank')").on("click", function (e) {
        e.preventDefault();
        openFullscreen();
    });

    // close shortcuts modal button
    $("#close").on("click", function (e) {
        e.preventDefault();
        $shortcutsModal.hide();
    });

});

