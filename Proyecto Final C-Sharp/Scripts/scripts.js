function Login_Submit()
{
    createCookie();
}

function createCookie()
{
	setcookie();
}

function setcookie(){

    document.cookie = "myusrname=" + document.getElementById('IdUsername').value + ";path/";
    document.cookie = "mypswd=" + document.getElementById('inputContra').value +";path";
}


function deleteCookie()
{
    var user = getCookie('myusrname');
    var passw = getCookie('mypswd');

    document.cookie = "myusrname =" + user + "; expires= Thu, 21 Aug 2014 20:00:00 UTC; path=/ "
    document.cookie = "mypswd =" + passw + "; expires= Thu, 21 Aug 2014 20:00:00 UTC; path=/ "

    document.cookie.value;
}


function getcookiedata(){
    console.log(document.cookie);

    var user = getCookie('myusrname');
    var pswd = getCookie('mypswd');

    document.getElementById('username').value = user;
    document.getElementById('password').value = pswd;
}

function getCookie(cname) {
    var name = cname + "=";
    var decodedCookie = decodeURIComponent(document.cookie);
    var ca = decodedCookie.split(';');

    for(var i = 0; i <ca.length; i++) {
      var c = ca[i];
      while (c.charAt(0) == ' ') {
        c = c.substring(1);
      }
      if (c.indexOf(name) == 0) {
        return c.substring(name.length, c.length);
      }
    }
    return "";
}