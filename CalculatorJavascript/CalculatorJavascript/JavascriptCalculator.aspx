<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JavascriptCalculator.aspx.cs" Inherits="CalculatorJavascript.JavascriptCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
    <script type="text/javascript"></script>
   
</head>
<body>
    <form id="form1">
        <div>
            <input id="firstNumber" type="text" value="1st number "/> <br />
            <input id="secondNumber" type="text" value="2nd number"/> <br />
            <input id="result" type="text" value="result "/><br />
            <input id="sum" type="button" value="Add" onclick="Addition()"/>
            <input id="multiply" type="button" value="Mul"/>
            <input id="substract" type="button" value="Sub"/>
            <input id="Division" type="button" value="Div"/>

        </div>
    </form>
</body>
        
        <script>    
        function Addition(){
            var FirstNumber = document.getElementById('firstNumber').value;
            var SecondNumber = document.getElementById('secondNumber').value;
            var Result = parseInt(FirstNumber) + parseInt(SecondNumber);
            document.getElementById('result').innerHTML = Result;
        }
     </script>
</html>
