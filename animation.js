const screens = document.querySelectorAll(".screen");
const startBtn = document.getElementById("startBtn");
const startBtn2 = document.getElementById("startBtn2");



startBtn.addEventListener('click', (event) => {
    event.preventDefault();
    screens[0].classList.add('up');
})


startBtn2.addEventListener('click', (event) => {
    // console.log(event.target)
    if (event.target.classList.contains("btn")) {
        screens[1].classList.add('up');
    }
})