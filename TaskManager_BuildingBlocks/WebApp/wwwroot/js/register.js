$(document).ready(function () {
    $("#emailInput").change(() => {
        const email = $("#emailInput").val();
        checkEmail(email);
    });

    $("#passwordInput").change(() => {
        const password = $("#passwordInput").val();
        checkPass(password);
    });

    $("#btnSubmit").click((e) => {
        let emailValit = false;
        let passValit = false;

        if (checkEmail($("#emailInput").val())) {
            emailValit = true;
        }

        if (checkPass($("#passwordInput").val())) {
            passValit = true;
        }

        if (!emailValit || !passValit) {
            event.preventDefault();
        }
    });

    const checkEmail = (email) => {
        if (email == "" || email == " " || email == null) {
            $("#emailError").text("This input is required.");
            return false;
        }
        else if (!/^[a-zA-Z0-9\.\-]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,3}$/.test(email)) {
            $("#emailError").text("Please enter a valid email.");
            return false;
        }
        else {
            $("#emailError").text("");
            return true;
        }
    }

    const checkPass = (password) => {
        if (password == "" || password == " " || password == null) {
            $("#passwordError").text("This input is required.");
            return false;
        }
        else if (password.length < 1 || password.length > 100) {
            console.log(password.length);
            $("#passwordError").text("Your password must be between 1 and 100 characters long.");
            return false;
        }
        else {
            $("#passError").text("");
            return true;
        }
    }
});