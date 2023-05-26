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

    const form = document.getElementById('SendForm');

    form.addEventListener('submit', (event) => {
        event.preventDefault(); 
        validateForm()
           
    });

    function validateForm() {
        const firstName = document.getElementById('Name').value;
        const secondName = document.getElementById('SecondName').value;
        const email = document.getElementById('Email').value;
        const phone = document.getElementById('Phone').value;
        const form = document.getElementById('SendForm');

        if (firstName.trim() === '' || secondName.trim() === '' || email.trim() === '' || phone.trim() === '') {
            
            form.style.border = "1px solid red";
            form.style.boxShadow = "0px 0px 10px red";
            alert("Данні в формі не відповідають правилам!");
        }
        else {
            form.style.border = "1px solid green";
            form.style.boxShadow = "0px 0px 10px green";
            clearForm();
            alert("Форма відправлена!")
        }
    }

    function clearForm() {
        document.getElementById('Name').value = '';
        document.getElementById('SecondName').value = '';
        document.getElementById('Email').value = '';
        document.getElementById('Phone').value = '';
    }
});



