function AddRemoveElements(input) {
    let arr = [];
    for (var i = 0; i < input.length; i++) {
      var splitInput = input[i].split(' ');
      if(splitInput[0] === "add"){
          arr.push(splitInput[1])
      }else if(splitInput[0] === "remove"){
          let index = Number(splitInput[1])
          arr.splice(index, 1)
      }
    }
    for (var j = 0; j < arr.length; j++) {
        console.log(arr[j]);
    }
}

AddRemoveElements([
    "add 3",
    "add 5",
    "remove 2",
    "remove 0",
    "add 7"

])