function Login_Submit()
{
    createCookie();
    onCookie();
}

function onCookie(){    
    document.getElementById('idRegistro').innerHTML = "CERRAR SESIÓN";
    document.getElementById('idRegistro').removeAttribute("data-bs-whatever");
    document.getElementById('idRegistro').removeAttribute("data-bs-target");
    document.getElementById('idRegistro').removeAttribute("data-bs-toggle");
    document.getElementById('idRegistro').setAttribute("onclick", "deleteCookie()");

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
	deleteCookieElvis();
	checkCookie();
}

function deleteCookieElvis(){
    var user = getCookie('myusrname');
    var passw = getCookie('mypswd');

    document.cookie = "myusrname =" + user + "; expires= Thu, 21 Aug 2014 20:00:00 UTC; path=/ "
    document.cookie = "mypswd =" + passw + "; expires= Thu, 21 Aug 2014 20:00:00 UTC; path=/ "

    document.cookie.value;
}

function checkCookie()
{
    if (!loadingContent())
    {
        
	window.location.href = "https://grupo2fundaesplai.000webhostapp.com/index.html";
    }
    else
    {
        //TO DO: alargar la vida de la cookie
		
    }
}

function loadingContent()
{
	
    //TO DO: verificar si existe la cookie
	if (getCookie("myusrname") != ""){
		    return true;
	} else {
		return false;
	}

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