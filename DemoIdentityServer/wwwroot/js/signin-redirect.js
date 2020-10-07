console.log('data-url', document.querySelector("meta[http-equiv=refresh]").getAttribute("data-url"))
window.location.href = document.querySelector("meta[http-equiv=refresh]").getAttribute("data-url");