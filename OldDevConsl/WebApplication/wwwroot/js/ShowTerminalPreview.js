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
        var regexArr = e.value.match(/<GeneratedUMapPath>\S+/);
        if (regexArr != null) {
            map = regexArr[0].replace("<GeneratedUMapPath>", "");
        }
        else {
            map = "";

        }

        
    }
    AllLeadToThisFunction(e);
}

function MouseDownOnBooleanArg(e) {
    var space = " ";
    argToBeAdded = space.concat(e.innerHTML.trim());

    if (e.id == "unset") {
        SetBooleanArg(e, true);

        shouldAddToArgArr = true;
    }
    else {
        SetBooleanArg(e, false);

        shouldAddToArgArr = false;
    }



    
    AllLeadToThisFunction(e);
}

function SetBooleanArg(e, newSet) {
    if (newSet == true) {
        e.style.setProperty("background-color", "#2acbf7");
        e.id = "set";
    }
    else {
        e.style.setProperty("background-color", "#5c77a9");
        e.id = "unset";
    }
    
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
        else {
            finalArgsString = finalArgsString.replace("<GeneratedUMapPath>", "");   //if there is no map name in common field delete <GeneratedUMapPath>
            
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
        let transientArgsString = e.value;
        if (map == "") {
            finalArgsString = finalArgsString.replace("<GeneratedUMapPath>", "");   //if there is no map name when they typed in the argsString delete <GeneratedUMapPath>
        }
        else

        finalArgsString = transientArgsString;
    }

}

function UpdateFormValues(e) {

    


    //Do string parsing so that we can get the map name based off of what they typed and each option argument that they typed in an array. Then we'll have all info needed to fill in the form values
    if (editedRawArgsString) {
        var currentArgsArr = finalArgsString.match(/ -\S+/g);
        for (let i = 0; i < argsToBeAddedArr.length; i++) {
            if (currentArgsArr.includes(argsToBeAddedArr[i])) {     //exesting arg exists in the new gathered args

            }
            else {                                                  //we lost an exesting arg
                var divs = document.getElementsByTagName("DIV");
                for (let j = 0; j < divs.length; j++) {
                    var buttonTxt = divs[j].innerText;
                    if (argsToBeAddedArr[i] == buttonTxt) {
                        SetBooleanArg(divs[j], false);
                        break;
                    }
                }
            }
        }
    }
    document.getElementById("Map").value = map;
    document.getElementById("Args").value = finalArgsString;    //set args form value to what weve come up with
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