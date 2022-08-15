document.getElementById('insert-form').addEventListener('submit', formSubmit);
function formSubmit(e) {
    e.preventDefault();
    const data = new FormData(e.target);
    const email = data.get('Email');
    const name = data.get('Name');
    const psw = data.get('Psw');
    const currentMonth = new Date("2022-02-15")
    console.log(currentMonth);
    const registerDate = new Date(currentMonth);
    
    var firstDay = new Date(registerDate.getFullYear(), registerDate.getMonth(), 2);
    var lastDay = new Date(registerDate.getFullYear(), registerDate.getMonth() + 1, 1);
    var formData = {
        email, name, psw, registerDate, firstDay, lastDay
    }
    $.ajax({
        type: 'POST',
        url: "/Home/Insert",
        data: {
            requestData: JSON.stringify(formData)
        },
        
        success: function (resultData) {
            console.log(resultData);
           
        }
    });
    console.log(formData);
    
}