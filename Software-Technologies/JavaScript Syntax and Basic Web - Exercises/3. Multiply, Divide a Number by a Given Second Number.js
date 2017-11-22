function multiplyDivideNumber(nums) {
    let x = Number(nums[0]);
    let y = Number(nums[1]);

    if(x <= y)
    {
       return x * y;
    }
    else
    {
        return x / y;
    }
}