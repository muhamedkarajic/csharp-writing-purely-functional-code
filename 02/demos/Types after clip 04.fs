type Currency = Currency of string;;

let usd = Currency("USD");;

type Amount = Amount of decimal * Currency;;

let deposit = Amount(5M, usd);;

type Money = 
  | Cash of decimal * Currency
  | Gift of decimal * Currency * System.DateTime;;
  
let instrument = Cash(20M, Currency("USD"));;

type Adder = Money * Amount * System.DateTime -> Money * Amount;;
