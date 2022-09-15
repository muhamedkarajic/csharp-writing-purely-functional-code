// Copy and paste in the F# Interactive window
// To open F# Interactive in Visual Studio
// select View -> Other Windows -> F# Interactive

// Alternatively: 
// Open file in Visual Studio
// Select all text, right-click and choose Execute in Interactive

type Equation = double * double * double

let discriminantOf ((a, b, c): Equation) = b*b - 4.*a*c

let squareRoots (x: double) =
  match x with
  | 0. -> [double 0.]
  | pos when pos > 0. -> [-sqrt pos; sqrt pos]
  | _ -> []
  
let tryDivideWith (divisor: double) (dividend: double) =
  match divisor with
  | 0. -> None
  | _ -> Some (dividend / divisor)

let seqAddTo (x: double) = Seq.map (fun y -> x + y)

let seqTryDivideBy (x: double) = Seq.choose (tryDivideWith x)

let solve ((a, b, c): Equation) =
  (a, b, c)
  |> discriminantOf
  |> squareRoots
  |> seqAddTo -b
  |> seqTryDivideBy (2. * a)
  
  ;;


solve (1., 3., 2.);;
solve (3., 1., 2.);;
solve (1., 5., 4.);;
solve (2., -4., 2.);;
