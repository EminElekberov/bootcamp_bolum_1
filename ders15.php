<?php 

$uyeler= [
    1,2,3
];
print_r($uyeler);



//<?php 
//
//$uyeler= [
//    1=>[
//        'ad'=>'emin',
//        'soyad'=>'elekberov'
//    ],
//    2,
//    3
//];
//print_r($uyeler);


<?php 

$uyeler= [
    1=>[
        'ad'=>'emin',
        'soyad'=>'elekberov',
        'pese'=>[
            'web'=>[
                'html','css','php','bootstrap','jquery'
            ]
        ]
    ]
    2,
    3
];
//print_r($uyeler);
echo $uyeler[1]['pese'][3];