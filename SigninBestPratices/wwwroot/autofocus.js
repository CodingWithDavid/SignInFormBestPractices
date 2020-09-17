function focusInputFromBlazor(selector) {
    var input = document.querySelector(selector);
    if (!focusInput(input)) {
        //input = input.querySelector("email");
        //focusInput(input);
    }
}

function focusInput(input) {
    if (input && input.focus) {
        input.focus();
    }
    else {
        return false;
    }
}