var argsToBeAddedArr = [];

var finalArgsString = "";
var prevFinalArgsString = "";
var prevElementEdited;
var map = "";
var game = "";
var argToBeAdded = "";
var prevArgAdded = "";

var editedRawArgsString = false;
var shouldAddToArgArr = false;


var leftMapString;
var rightMapString;

function OnEditCommonArg(e) {
    if (e.id == "Game") {
        game = e.value;
    }
    else if (e.id == "Map") {
        map = e.value;
    }
    AllLeadToThisFunction(e);
}

function OnEditArgs(e) {
    if (e.id == "Args") {
        editedRawArgsString = true;
    }
    AllLeadToThisFunction(e);
}

function MouseDownOnBooleanArg(e) {
    var space = " ";
    argToBeAdded = space.concat(e.innerHTML.trim());

    if (e.id == "unset") {
        e.style.setProperty("background-color", "#2acbf7");
        e.id = "set";

        shouldAddToArgArr = true;
    }
    else {
        e.style.setProperty("background-color", "#5c77a9");
        e.id = "unset";

        shouldAddToArgArr = false;
    }



    
    AllLeadToThisFunction(e);
}


function AllLeadToThisFunction(e) {
    UpdateFinalArgsStringGivenCurrentInformation(e);
    UpdateFormValues(e);
    ResetGlobalVars();
}

function UpdateFinalArgsStringGivenCurrentInformation(e) {   //constructing the args string (finalArgsString gets reconstructed every time)
    if (!editedRawArgsString) {
        if (map != "") {
            var generatedUMapPath = "<GeneratedUMapPath>";
            var mapArg = generatedUMapPath.concat(map);
            finalArgsString = finalArgsString.concat(mapArg);       //1st append map arg
        }
        

        if (shouldAddToArgArr) {
            let newLength = argsToBeAddedArr.push(argToBeAdded);
        }
        else {
            if (argToBeAdded != "") {
                let pos = argsToBeAddedArr.indexOf(argToBeAdded)
                let removedItem = argsToBeAddedArr.splice(pos, 1);      //remove item at pos
            }
        }

        for (let i = 0; i < argsToBeAddedArr.length; i++) {            //lastly append the argsToBeAddedArr 


            finalArgsString = finalArgsString.concat(argsToBeAddedArr[i]);
        }
    }
    else {
        finalArgsString = e.value;
    }
    
}

function UpdateFormValues(e) {
    document.getElementById("Args").value = finalArgsString;    //set args form value to what weve come up with

    //Do string parsing so that we can get the map name based off of what they typed and each option argument that they typed in an array. Then we'll have all info needed to fill in the form values
    if (editedRawArgsString) {
        var argsArr = finalArgsString.match(/\s-([\S]+)/);
        for (let i = 0; i < argsArr.length; i++) {


        }
    }
}

function ResetGlobalVars() {
    prevFinalArgsString = finalArgsString;
    finalArgsString = "";
    prevArgAdded = argToBeAdded;
    argToBeAdded = "";
    shouldAddToArgArr = false;
    editedRawArgsString = false;
}




















function MouseDownEditButton() {
    document.getElementById("Args").toggleAttribute("readonly");


    var element = document.getElementById("EditButton");
    element.style.setProperty("background-color", "#a3a3a3");

    
    if (document.getElementById("Args").hasAttribute("readonly")) {
        element.innerHTML = "Enable Editing";
    }
    else {
        element.innerHTML = "Disable Editing";
    }
}

function MouseUpEditButton() {
    var element = document.getElementById("EditButton");
    element.style.setProperty("background-color", "#e8e8e8");
}