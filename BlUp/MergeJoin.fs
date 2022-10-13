namespace BlUp

module MergeJoin =

    let mj (lComp: 'a -> 'c) (rComp: 'b -> 'c) (left: 'a array) (right: 'b array) : 'a list * ('a * 'b) list * 'b list =
        let rec loop a b justL both justR =
            match Array.tryItem a left, Array.tryItem b right with
            | Some ia, Some ib when lComp ia < rComp ib -> loop (a + 1) b (ia :: justL) both justR
            | Some ia, Some ib when lComp ia > rComp ib -> loop a (b + 1) justL both (ib :: justR)
            | Some ia, Some ib -> loop (a + 1) (b + 1) justL ((ia, ib) :: both) justR
            | None, Some ib -> loop a (b + 1) justL both (ib :: justR)
            | Some ia, None -> loop (a + 1) b (ia :: justL) both justR
            | None, None -> (justL, both, justR)

        loop 0 0 [] [] []
