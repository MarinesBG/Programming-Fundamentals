function sumThreeIntegers(nums) {

    if(nums[0] === nums[1] + nums[2]){
        let a = Math.min(nums[1],nums[2]);
        let b = Math.max(nums[1],nums[2]);
        console.log(${a} ${"+"} ${b} ${=} ${nums[0]});
    }
    else if(nums[1] === nums[0] + nums[2]){
        let a = Math.min(nums[0],nums[2]);
        let b = Math.max(nums[0],nums[2]);
        console.log(${a} ${"+"} ${b} ${=} ${nums[1]});
    }
    else if(nums[2] === nums[1] + nums[0]){
        let a = Math.min(nums[1],nums[0]);
        let b = Math.max(nums[1],nums[0]);
        console.log(${a} ${"+"} ${b} ${=} ${nums[2]});
    }
    else
    {
        console.log(${No})
    }
}