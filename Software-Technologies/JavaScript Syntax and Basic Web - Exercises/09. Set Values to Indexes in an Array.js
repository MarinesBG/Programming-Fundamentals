function ValuesIndexes(nums) {
    let arr = [];
    for (let i = 1; i < nums.length; i++) {
       let line = nums[i];
       let splitInput = line.split(" - ");
       let index = Number(splitInput[0]);
       arr[index] = Number(splitInput[1]);
    }
    for (var i = 0; i < Number(nums[0]); i++) {
        if(arr[i] === undefined){
            console.log(0);
        }else{
            console.log(arr[i]);
        }
    }
}

ValuesIndexes([
    "5",
    "0 - 3",
    "3 - -1",
    "4 - 2"
])