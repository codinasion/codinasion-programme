<?php
// Write a programme to find negative of a number
// quick def (9 = -9 and -9 = 9 and string = not a number but "90" is a number)

$number = 43;
print 'Input  : ' . $number;

function findNegativeNum($num)
{
    // this keep you float value in float
    if (gettype($num) == 'integer' or gettype($num) == 'double') {
        $negative = $num - $num * 2;
        return $negative;
    } else {
        // try to convert string into number if possible ("9") != number
        if ($con = intval($num)) {
            $negative = $con - $con * 2;
            return $negative;
        } else {
            return "Can not convert into number\nNot a Number";
        }
    }
}

$result = findNegativeNum($number);
print "\nOutput : " . $result;
print "\n";

?>
