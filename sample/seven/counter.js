function initX()
{
    counter_div = document.getElementById("counter");
    digits = counter_div.getElementsByTagName("img");

    var i;
    for(i = 0; i < digits.length; i++)
    {
        digits[i].src = counter_value[i] + ".png";
    }
}

