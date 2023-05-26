document.addEventListener("DOMContentLoaded", (event) => {
    var firstTitle = document.getElementById('firstTitle');
    var secondTitle = document.getElementById('secondTitle');
    var thirdTitle = document.getElementById('thirdTitle');

    firstTitle.addEventListener('click', () => {
        var first = document.getElementById('first');
        first.classList.toggle('hide');
    });

    secondTitle.addEventListener('click', () => {
        var second = document.getElementById('second');
        second.classList.toggle('hide');
    });

    thirdTitle.addEventListener('click', () => {
        var third = document.getElementById('third');
        third.classList.toggle('hide');
    });
});


