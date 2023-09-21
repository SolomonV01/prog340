function sumNumSquareNum()
{
    let numberOne, numberTwo, sum, squareRootOne, squareRootTwo;

    numberOne = parseInt(document.getElementById("numberOne").value);
    numberTwo = parseInt(document.getElementById("numberTwo").value);

    sum = numberOne + numberTwo;
    document.getElementById("sumAnswer").value = sum;

    squareRootOne = Math.sqrt(numberOne);
    document.getElementById("sqrtAnswerOne").value = squareRootOne;

    squareRootTwo = Math.sqrt(numberTwo);
    document.getElementById("sqrtAnswerTwo").value = squareRootTwo;
}

function clearAll()
{
    document.getElementById("numberOne").value = "";
    document.getElementById("numberTwo").value = "";
    document.getElementById("sumAnswer").value = "";
    document.getElementById("sqrtAnswerOne").value = "";
    document.getElementById("sqrtAnswerTwo").value = "";
}