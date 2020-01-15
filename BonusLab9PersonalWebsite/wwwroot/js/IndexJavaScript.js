//attach event handlers to the buttons
document.querySelector("#clr").addEventListener("click", clr);
document.querySelector("#add").addEventListener("click", add);
document.querySelector("#subtract").addEventListener("click", subtract);
document.querySelector("#multiply").addEventListener("click", multiply);
document.querySelector("#divide").addEventListener("click", divide);
document.querySelector("#mod").addEventListener("click", mod);

function clr() {
    //zero the output
    document.querySelector("#answer").innerText = "";
    //clear the inputs
    document.querySelector("#op1").value = 0;
    document.querySelector("#op2").value = 0;
}

function add() {
    let ans = parseInt(document.querySelector("#op1").value)
        + parseInt(document.querySelector("#op2").value);
    document.querySelector("#answer").innerText = ans;
}

function subtract() {
    let ans = document.querySelector("#op1").value
        - document.querySelector("#op2").value;
    document.querySelector("#answer").innerText = ans;
}

function multiply() {
    let ans = document.querySelector("#op1").value
        * document.querySelector("#op2").value;
    document.querySelector("#answer").innerText = ans;
}

function divide() {
    let ans = document.querySelector("#op1").value
        / document.querySelector("#op2").value;
    document.querySelector("#answer").innerText = ans;
}

function mod() {
    let ans = document.querySelector("#op1").value
        % document.querySelector("#op2").value;
    document.querySelector("#answer").innerText = ans;
}
