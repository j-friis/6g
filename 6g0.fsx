(* Opgave 6g.0
 *
 * Gruppe 10:
 *  Jonas Friis
 *  Claes Christian Heise
 *  Morten Risum Pedersen
 *)

///<summary>
///Takes a list of integers as a continued fraction,
///and computes the comparative real number.
///</summary>
///<params name="lst">
///A list of integers, where each int qn = q0+(1/(q1+(1/(q2+...))))
///</params>
///<returns>
///A float
///</returns>
///<remarks>
///
///</remarks>
let rec cfrac2float (lst : int list) : float =
  if lst.Length = 1 then float lst.Head
  else float lst.Head + 1.0/(cfrac2float lst.Tail)

printfn "%A" (cfrac2float [3;4;12;4])