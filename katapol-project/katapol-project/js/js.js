function CheckInputBingo() {
    //validate input
    var result = false;
    var value = document.getElementById("txtInput").value;
    
    //alert("eee");
}


//////////////////////////////////////////////////////////////////////////////////


function CheckInputFormulaCalculation() {
    alert("eee");
}

function ReplaceSpace() {
    var inputCalculation = document.getElementById("txtInputCalculation").value.split(" ").join("");

    document.getElementById("txtInputCalculation").value = inputCalculation;
}


function CheckInputCalculation() {
    var validateText = "";
    var textNumber = "0123456789";
    var textSymbol = "()+-*/";

    validateText = textNumber + textSymbol;

    var str = document.getElementById("txtInputCalculation").value;
    var strLength = str.length;

    var check = true;
    var strCharAt = "";
    for (i = 0; i < strLength; i++) {
        strCharAt = str.charAt(i);
        if (validateText.indexOf(strCharAt) == -1) {
            check = false;
            alert("format incorrect");
            break;
        }
    }
    
    return check;
}