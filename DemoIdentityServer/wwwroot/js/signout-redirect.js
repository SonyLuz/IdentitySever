window.addEventListener("load", function () {
    var a = document.querySelector("a.PostLogoutRedirectUri");
    console.log('a', a);
    if (a) {
        console.log('a.href', a.href);
        window.location = a.href;
    }
});