//#region STARTUP

window.appCultureRoute = "/fa";
window.appDomain = document.domain;
window.appPort = location.port;
window.appProtocol = location.protocol;
window.appHost = location.hostname;

var parts = location.hostname.split('.');
var subdomain = parts.shift();
var upperleveldomain = parts.join('.');

if (window.appPort === null)
    window.appCurrentDomainUrl = window.appProtocol + "//" + upperleveldomain;
else
    window.appCurrentDomainUrl = window.appProtocol + "//" + upperleveldomain + ":" + window.appPort;

/**
 * متد اصلی اجرا کننده ی اسکریپت های برنامه
 */
$(document).ready(function () {

    onLoadNavigator();
    startUp();
    enableSubmitButton();
});

//#endregion STARTUP