$(document).ready(function () {
    $('header').empty();
    $('footer').empty();

    $("#emailInput").change(() => {
        const email = $("#emailInput").val();
        checkEmail(email);
    });

    $("#passwordInput").change(() => {
        const password = $("#passwordInput").val();
        checkPass(password);
    });

    $("#submit").click((event) => {
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
        else if (!/^[a-z0-9\.\-]+@[a-z0-9]+\.[a-z]{2,3}$/.test(email)) {
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
            $("#passError").text("This input is required.");
            return false;
        }
        else {
            $("#passError").text("");
            return true;
        }
    }
});