<<<<<<< HEAD
﻿﻿# Primes
=======
﻿# Primes
>>>>>>> 3c77a1043398f2ef49f6f6444086a9b1e7309fe0
## A 2D esoteric programming langauge based on the popular [Brainfuck](https://esolangs.org/wiki/Brainfuck) esolang!

### Usage:
##### Operations are based on the numbers that are inputted, if you put in a number for example 143, this number has 2 prime factors, those being 11 and 13, this gives a total of 2 factors; this value is then used as the number to look up against when the final code is interpreted.

### Instruction set:
| Instruction | # of prime factors |
|-------------|--------------|
|`0` halt|`0`|
|`>` pointer left|`1`|
|`<` pointer right|`2`|
|`^` pointer up|`3`|
|`v` pointer down|`4`|
|`+` value add 1|`5`|
|`-` value sub 1|`6`|
|`(` start loop|`7`|
|`)` end loop|`8`|
|`.` print value|`9`|
|`,` input value|`10`|
|`#` reset value|`11`|

## Example programs
##### Hello World! -
```
32 32 32 32 32 32 32 32 32 32 128 16 32 32 32 32 32 32 32 16 32 32 32 32 32 32 32 32 32 32 16 32 32 32 32 32 32 32 32 32 32 32 16 32 32 32 16 32 32 32 32 32 32 32 32 32 16 32 32 32 32 32 32 32 32 32 32 8 8 8 8 8 8 64 256 16 32 32 512 16 32 512 16 64 64 512 512 32 32 32 512 16 32 32 512 16 64 64 64 512 8 8 512 32 32 32 512 64 64 64 64 64 64 512 16 16 16 512 8 8 32 512 0
```

This results in the same output:

```
3675 924 2310 378 11858 9075 252 3675 616 450 8820 126 2625 2310 8470 1540 6050 990 8470 198 990 11319 7986 1386 5390 280 700 46585 3087 21175 2401 1540 990 6050 3630 4851 2310 450 3465 2310 11319 2310 132 11858 2205 12705 308 72 1386 660 1650 2178 3388 11319 990 378 1155 8085 8470 3388 2079 7546 33275 8470 2058 3234 11979 42 63 363 66 147 231 130438 335412 189 17787 2205 138600 308 180 479160 1155 10780 11550 686070 1067220 3234 3850 5775 1031250 525 630 18634 5534298 198 11550 38115 7350 121968 50 44 12478125 2156 630 5082 762300 19250 4950 1232 63525 23958 6174 457380 770 484 1155 123480 30 18 660 2546775 0
```

##### 99 Bottles of Beer -

```
2 32 32 32 32 32 32 32 32 32 32 128 4 32 32 32 32 32 32 32 32 32 32 2 64 256 4 64 2 2 2 2 2 32 32 32 128 2 32 32 32 2 32 32 32 4 4 64 256 4 4 4 4 32 4 128 2 128 2 32 2 32 4 4 64 256 2 2 128 64 4 4 32 2 2 256 32 32 32 32 2 32 4 128 64 4 64 2 256 4 128 128 64 256 2 2 64 4 4 256 2 2 128 128 64 256 4 4 32 2 2 256 4 4 128 128 64 256 2 2 2 2 2 2 128 128 64 256 4 32 32 32 32 32 32 32 32 32 32 4 64 2 2 256 4 64 128 2 32 2 32 4 4 64 256 2 128 4 32 2 64 256 32 2 128 128 64 256 4 64 2 256 4 4 4 4 4 4 4 4 4 64 2 2 256 4 128 2 32 2 32 4 4 64 256 2 2 128 64 4 4 32 2 2 256 32 2 32 4 128 64 4 64 2 256 4 128 128 64 256 2 2 64 4 4 256 2 2 128 128 64 256 4 4 32 2 2 256 4 4 4 128 2 2 32 2 32 4 4 4 64 256 2 2 2 128 64 4 4 4 32 2 2 2 256 32 32 2 32 4 128 64 4 64 2 256 4 128 128 64 256 2 2 64 4 4 256 2 2 128 128 64 256 4 4 32 2 2 256 4 4 128 2 32 4 128 64 256 256 4 128 2 2 32 4 4 128 64 256 256 2 2 128 4 4 32 2 2 128 64 256 256 4 4 4 128 2 2 32 2 32 4 4 4 64 256 2 2 2 128 64 4 4 4 32 2 2 2 256 32 32 32 32 2 32 4 128 64 4 64 2 256 4 128 128 64 256 2 2 64 4 4 256 2 2 128 128 64 256 4 4 32 2 2 256 4 4 128 2 32 4 128 64 256 256 4 128 2 2 32 4 4 128 64 256 256 2 2 128 4 4 32 2 2 128 64 256 256 4 4 128 128 64 256 2 2 2 32 32 32 32 32 32 32 32 128 2 2 32 32 32 32 32 32 4 4 64 256 2 128 4 32 32 32 32 32 32 32 32 128 2 32 32 32 32 32 32 4 64 256 2 512 4 32 32 32 32 32 32 32 32 128 2 64 64 64 64 64 64 4 64 256 2 128 4 4 32 2 2 64 256 256 2 512 4 4 32 32 32 32 32 32 32 32 128 2 2 64 64 64 64 64 64 4 4 64 256 4 128 64 2 2 32 4 4 256 4 32 32 32 32 32 32 32 32 128 4 32 32 32 32 2 64 256 4 512 2 32 32 32 32 32 32 32 128 2 32 32 32 32 32 32 32 32 32 4 64 256 2 32 32 32 512 4 32 32 32 32 32 128 2 32 32 32 32 32 32 32 32 32 4 64 256 2 512 32 32 32 32 32 512 512 64 64 64 64 64 64 64 64 512 64 64 64 64 64 64 64 512 32 32 32 32 32 32 32 32 32 32 32 32 32 32 2 2 128 2 2 2 32 2 32 4 4 4 4 64 256 2 2 2 2 128 64 4 4 4 4 32 2 2 2 2 256 2 32 4 128 64 4 64 2 256 4 128 128 64 256 2 2 64 4 4 256 2 2 128 128 64 256 4 4 32 2 2 256 4 4 4 4 128 2 2 2 32 2 32 4 4 4 4 64 256 2 2 2 2 128 64 4 4 4 4 32 2 2 2 2 256 32 2 32 4 128 64 4 64 2 256 4 128 128 64 256 2 2 64 4 4 256 2 2 128 128 64 256 4 4 32 2 2 256 4 4 4 128 2 2 32 4 4 128 64 256 256 2 128 2 32 4 128 64 256 256 32 32 2 2 32 4 128 64 4 64 2 256 4 128 128 64 256 2 2 64 4 4 256 2 2 128 128 64 256 4 4 32 2 2 256 4 32 4 128 128 64 256 2 64 4 256 2 128 4 4 4 4 4 4 4 512 2 2 2 2 2 2 2 128 64 256 256 4 4 4 4 4 4 4 4 4 512 2 2 64 64 64 64 512 64 64 64 64 64 64 64 64 64 512 4 4 512 2 2 64 64 64 64 512 32 32 32 512 512 32 32 32 32 32 32 32 32 32 32 32 32 32 512 128 64 256 4 4 128 64 256 256 4 128 2 32 2 32 4 4 64 256 2 2 128 64 4 4 32 2 2 256 32 2 32 4 128 64 4 64 2 256 4 128 128 64 256 2 2 64 4 4 256 2 2 128 128 64 256 4 4 32 2 2 256 4 4 4 128 2 2 32 2 32 4 4 4 64 256 2 2 2 128 64 4 4 4 32 2 2 2 256 32 32 32 32 2 32 4 128 64 4 64 2 256 4 128 128 64 256 2 2 64 4 4 256 2 2 128 128 64 256 4 4 32 2 2 256 4 4 128 2 32 4 128 64 256 256 4 128 2 2 32 4 4 128 64 256 256 2 2 128 4 4 32 2 2 128 64 256 256 4 4 128 128 64 256 2 32 32 32 32 32 32 32 32 128 4 32 32 32 32 2 64 256 4 512 2 32 32 32 32 32 32 32 32 32 32 128 2 32 32 32 32 32 32 32 32 32 32 32 4 64 256 2 32 512 64 512 4 4 512 2 2 32 32 32 32 32 32 512 64 64 64 64 64 64 64 64 64 64 64 64 512 64 64 64 512 4 4 512 2 32 32 32 32 32 32 128 2 32 32 32 4 64 256 2 512 4 32 32 32 32 32 32 128 2 64 64 64 64 4 64 256 2 32 32 512 32 32 32 32 32 32 32 32 32 32 32 512 512 128 64 256 4 4 128 64 256 32 32 32 32 32 32 32 32 32 32 512 128 64 256 256 4 128 2 32 2 32 4 4 64 256 2 2 128 64 4 4 32 2 2 256 32 32 32 2 32 4 128 64 4 64 2 256 4 128 128 64 256 2 2 64 4 4 256 2 2 128 128 64 256 4 4 32 2 2 256 4 4 128 128 64 256 32 32 32 32 32 32 32 32 32 32 512 2 32 32 32 32 32 32 32 32 32 128 2 32 32 32 32 32 32 32 32 32 4 64 256 2 32 32 32 512 32 32 32 32 32 32 32 32 32 32 32 32 32 512 32 32 32 32 32 32 32 32 32 32 512 64 64 64 64 64 64 512 4 32 32 32 32 32 32 32 32 128 2 2 32 32 32 32 4 4 64 256 2 2 512 4 32 32 32 32 32 32 32 32 32 32 512 64 512 64 64 64 64 64 64 64 64 64 512 2 512 4 64 512 32 32 32 32 32 32 32 32 32 32 32 512 32 32 32 32 32 32 32 32 512 64 64 64 64 64 64 64 64 64 512 2 512 4 64 64 64 64 64 64 64 64 64 64 64 64 64 512 32 32 32 32 32 32 32 32 32 32 32 32 32 512 64 64 64 64 64 64 64 64 64 64 512 2 512 4 32 32 32 32 32 32 32 32 32 32 32 32 512 64 64 64 64 64 64 64 64 64 64 64 64 64 64 64 512 4 32 32 32 128 2 32 32 32 32 32 32 4 64 256 2 512 512 2 512 4 64 64 64 64 64 64 64 64 64 64 512 32 32 32 32 32 32 32 32 32 32 32 512 2 512 4 4 32 32 32 128 2 64 64 64 64 64 64 4 64 256 2 64 512 32 32 32 32 32 32 32 32 32 32 32 32 32 32 32 32 32 512 64 64 64 512 32 32 32 32 32 32 512 64 64 64 64 64 64 64 512 64 64 64 64 64 64 64 64 64 64 512 128 64 256 2 128 64 256 4 4 4 512 128 64 256 256 4 128 2 32 2 32 4 4 64 256 2 2 128 64 4 4 32 2 2 256 32 32 32 32 2 32 4 128 64 4 64 2 256 4 128 128 64 256 2 2 64 4 4 256 2 2 128 128 64 256 4 4 32 2 2 256 4 4 128 128 64 256 32 32 32 32 32 32 32 32 32 32 512 128 64 256 4 128 64 256 2 256 4 32 4 256 0
```

This results in the same output:

```
2 6050 450 3675 6050 29645 1650 700 1575 440 990 3000 77 378 300 2205 4375 1540 1386 7623 108 46585 594 3 6930 355740 21 18150 11 3 11 2 3 9075 5082 21175 2282665 3 2450 630 8575 7 2058 1100 924 35 33 23716 355740 121 10 15 25 924 33 20790 7 75460 11 6050 7 11319 9 21 540 73500 11 5 15400 35574 21 22 3388 2 5 41160 2420 180 924 2205 2 660 10 54450 7700 10 1848 5 150920 10 1584 80850 1500 7263025 5 5 6468 77 10 359370 3 2 978285 177870 540 5400 14 35 924 7 5 218295 9 6 15400 54450 6534 237160 5 11 7 7 2 7 8820 45276 6468 234256 10 18634 2475 2310 300 12705 13475 2178 2750 450 990 6 56595 2 11 1980825 14 2500 13860 3 243 2 13475 35 55 18150 1976535 2 5544 4 5390 5 11550 69300 924 3 45738 41250 16170 154350 55 8250 7 30800 22 21 77 14 6 15 49 14 35 15092 11 3 790614 4 1452605 11 2058 11 5390 14 10 4950 145530 11 2 282975 23958 4 10 2156 7 5 11880 12705 7 8085 49 2376 79233 55 42350 11 1317690 55 871563 190575 3300 339570 7 5 56595 10 77 161700 11 5 14850 20328 26950 43560 33 6 18634 7 2 140625 25 21 10 23100 11 3 3087 2 9625 22 9 21 5250 952875 2 2 11 53900 25410 35 35 4 1540 11 7 3 203742 1050 630 2 4125 25 177870 11550 14 58564 2 756250 55 36750 45738 25410 213444 5 7 148225 14 15 27720 3 5 2520 3000 38115 12600 22 21 660 2 5 1334025 55 22 465850 11 8470 14 8712 12375 72600 272250 25 27500 7 7 2310 55 6 6300 63525 68600 173250 3 5 111804 33 55 1650 11 2 444675 25410 453750 1245090 77 77 15 166012 2 7 2156 5 378 10 55 14 5250 26730 3 7 11 30492 2772 21 35 6 630 11 2 7 1956570 8085 200 8575 1100 11 3465 10 13552 27225 55 55902 7 27720 22 68607 19404 352 533610 11 5 23958 6 77 1296 2 5 13860 121275 18150 2196150 33 33 450 5 5 475398 21 9 10500 5 924 10 2282665 10395 320166 3112725 33 622545 2 3 13310 77 35 3587045 58564 838530 559020 2 3 84700 21 22 12705 2 7 202125 10290 635250 152460 77 49 86625 177870 11550 7174090 2 2 2 29645 440 80 750 108 1575 3388 12705 21560 11 5 1650 3234 5445 7986 1386 8085 9 21 139755 1844766 7 48510 14 3234 17787 567 300 13475 11319 750 9075 6160 2 5775 4851 924 21175 1386 8085 6 25725 527076 2 130680 15 1470 176 280 3267 630 5445 252 990 202125 3 25410 7260 16335 25725 1980 2200 10 39930 7128 5 177870 6 21 3430 11 11 42350 2905210 101640 11 5534298 121 121 1452 27951 2310 750 7546 1750 1575 5775 249018 2 2 2100 2940 7260 6237 59290 38115 22 6 26950 242550 22 57750 10890 2 3 8470 22 77 559020 77 3465 1470 108 990 29645 5082 3630 26411 249018 14 8085 630 3465 168 3 17325 272250 77 2635380 11 15125 180 3388 21175 2156 1452 12705 13860 5 2310 5775 2420 2079 65219 924 5445 2310 3388 15 1980 381150 11 8085 450 588 123480 10 5082 5445 18865 3675 660 19602 5 12705 5082 5775 5390 1386 7203 630 1540 1372 21 55902 381150 2 485100 168 660 1650 500 945 3961650 3361743 26620 16940 1764 24255 11550 88935 3750 25410 121968 336 1980 4725 19250 2772 7700 39930 231000 420 300 12705 3465 5445 252 9075 5445 5390 750 5775 15125 112 420 5 7 30492 2 7 5 3234 2 1372 6 35 9 21 42350 381150 2 5 2 2 373527 166375 6 21 14 14 2475 2 2 11 7 60984 5 17787 9 8712 1960 6 22638 3 7174090 77 415030 55125 6930 102900 11 2 25410 33 49 635250 2 7 36300 20328 4410 3112725 33 14 6050 11 7 11760 15 77 14 35 237699 11 3 2 2079 2 33275 33 35 25 77 2970 800415 2 3 2 7 34650 55902 121 49 55 25 1100 3 7 3 3 152460 7546 2 2450 25 1800 16170 10 2100 5 943250 77 15750 978285 4900 97020 3 11 38115 33 55 161700 3 7 24500 2352 88935 163350 33 35 420 3 2 123750 14 10 55 111804 7 3 990 15 6 45738 3500 1397550 257250 5 8820 5 396 6 71874 18150 1245090 115500 1540 1386 3 2 5775 77 5880 600 4 9702 11 39690 22 190575 186340 132055 2223375 7 5 42875 22 6 152460 11 7 7000 20580 10164 2400 35 6 5145 2 7 115500 15 1485 22 13230 7000 15092 363825 3 45375 4 145530 3 167706 121 35 35 10 10 21 9 1565256 2 3 7 11 11 11 5 79860 10290 29040 152460 35 33 49 15 55 55 6 10 22 1143450 2 5 360 59290 2646 11025 485100 7350 99825 148225 810 16170 1848 4620 2100 2772 6149220 35 10 1600830 7 7 4410 2940 35574 18150 83160 3388 1386 29645 9782850 3176250 4125 2310 2178 440 2310 2420 2178 990 1485 450 300 17787 17787 1886500 586971 99825 254100 33 4 13860 22638 592900 65340 77 41250 3 3465 3 13310 14 15 40425 4304454 3 11 6750 22638 22 55 2205 2 3 152460 2178 5 3465 21 419265 23716 9 307461 3 635250 21 14700 15400 9702 8800 2 5 195657 35 77 5280 5 2 8820 71148 2940 503118 25 6 252 11 3 97020 77 21 15 36300 7 5 660 7 9625 21 15 9 4900 1010625 5 3 3 71148 42350 10 33 15 4125 3 11 11 226380 33275 2079 8085 3234 7 700 15 50820 1176 6 15092 11 152460 35 14850 121275 18150 503118 3 5 1890 35 6 363825 7 5 658845 76230 93170 43560 6 9 3430 2 5 4891425 25 4 1164625 7 594 14 119790 4900 78750 155925 6 51975 7 3 1372 35 4 23100 6468 598950 26136 7 7 249018 9 35 968 11 5 186340 42350 37422 830060 55 14 34650 14850 18150 97020 5 2178 2156 2310 12705 616 1650 5390 616 1037575 55 17787 2420 1485 3630 2 3150 4108797 22 1286250 2 1050 3850 8085 3465 924 1386 882 660 5775 8575 13068 11 660 1452 3234 420 168 3850 8470 8470 2450 1470 1470 77 4158 355740 5 9075 323400 4725 1067220 35 55 79893275 2 5 1470 630 2079 588 12705 1050 35280 11550 4312 59290 195657 148225 9702 17150 18150 2646 23716 37730 48125 49896 16170 1188 28875 124740 77 14 2459688 2 396 630 420 1470 2079 392 2520 2 1470 200 3465 14 900 37044 2 34239975 121 3087 2750 5082 8470 4802 1575 37125 7 28875 63525 88935 6615 77 7425 108900 5 7546 2178 34239975 200 11858 300 2625 108 1485 3465 6050 18634 19965 180 4446750 59400 50820 15435 142296 33 15 71148 53361 381150 500 1575 1575 882 5390 252 594 9625 2310 4851 15563625 2352 93170 533610 149072 35 46305 5 7546 2 27951 22 35 63525 533610 7 3 47916 7260 35 22 2178 7 2 504210 5390 2310 5390 2 7986 35 20328 26950 21 11025 11 228690 10 9800 249018 6930 145530 11 5 5250 35 77 216090 2 5 9240 111804 6930 107800 15 15 12705 2 3 24948 35 25 419265 34650 26620 29040 392 630 13475 2058 630 12705 3850 1050 882 630 9782850 3 1470 13475 7546 8575 1386 5775 12705 3630 588 1037575 5 980 980 1540 990 4851 5775 990 12705 280 33 166375 29700 2 1050 13310 73205 2701125 9625 2156 420 3087 1452 1323 2450 630 5082 420 2156 12705 594 291060 5775 7623 1323 8085 990 4802 7623 162 8470 980 1426194 25410 26950 6468 6468 4158 88935 19174386 21 630 46585 1540 108 1470 72 420 9625 127050 5 3 5445 7546 6050 5390 6 9 11550 129654 11 2 13865775 121 2750 3850 5390 46585 750 2750 8470 5775 2625 2750 16304750 1980 304920 40425 37730 1764 7260 30625 2100 16170 53361 42350 13528284 7 9072 77 3300 485100 6125 882 200 968 450 1650 1050 588 2310 630 1386 15563625 3267 2156 5775 1485 72 180 616 252 5282739 3080 148225 4725 11550 146410 1260 2100 1890 6930 640332 2 5869710 35 18150 33957 124509 63525 900 4356 6174 1848 39930 456533 40425 2025 7350 145200 17787 1386 450 1050 48 3465 405 2310 2750 26411 9625 9625 5775 32283405 6930 19250 6930 1215 40425 528 3500 53361 2835 4620 2668050 2 490050 21 3388 1452 264 48 3234 46585 3630 5445 5775 120 3388 3388 1331000 1260 2970 2772 23716 16940 326095 4950 6174 2904 1232 18150 23716 39930 6174 94325 3486252 9 43923 29645 588 113190 5 5390 21175 2058 12705 270 27951 55 16170 3112725 7 670824 1443750 5 50218630 21 25410 63525 10164 25410 25410 4356 17325 1260 4158 1320 10375750 2475 48 2310 300 5445 3465 280 980 7546 200 280 157500 3 6288975 4 4 5082 1386 11858 6160 11 55902 53361 2835 6930 40425 124509 49 139755 49500 11 2100 174636 1575 168 13475 1650 168 1650 8470 396 1050 180 1650 7986 6050 21175 3850 980 5082 242000 15246 7700 2904 1494108 1386 264 2475 5082 29645 1470 59400 38115 37730 17150 4900 11550 24255 7700 3735270 1701 1936 16335 15092 22869 83006 1260 7700 2940 4620 304920 978285 8250 2223375 11 20580 99825 12810875 10 22 77 1347500 31185 6468 226380 13500 10 46305 3 4125 11 280 14 21 5250 239580 2 11 31185 756 14 10 8470 5 3 142296 396 3850 5390 5390 7 65219 22 419265 7260 10 38115 11 335412 4 3564 80850 93170 213444 5 5 18150 15 33 216090 7 7 30184 1537305 18150 747054 77 4 1050 2 5 18480 55 15 3696 19404 42350 5187875 6050 5445 5390 588 3465 1100 2475 1750 3465 1470 3913140 34300 99825 359370 35 53900 4950 3660250 7 110250 4 3234 22 152460 0
```
