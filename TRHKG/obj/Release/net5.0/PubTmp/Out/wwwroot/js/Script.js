let btn = document.getElementById('knowMoreBtn');
console.log(btn);


let popup = document.getElementById('wrapperPopup');

let popupClose = document.querySelector('.close');

btn.onclick = function () {
    popup.style.display = "block";
}



popupClose.onclick = function () {
    popup.style.display = "none";
}