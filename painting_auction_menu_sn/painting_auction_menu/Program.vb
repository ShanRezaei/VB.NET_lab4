Imports System
Imports System.IO.Compression
Imports System.Runtime.InteropServices

Module Program

    Structure Painting
        Dim num As Integer
        Dim artist_name As String
        Dim title As String
        Dim price
        Dim rank
        Dim sold_status As String
    End Structure


    Sub Main(args As String())


        Dim paint_list As New List(Of Painting)
        Dim obj As New Painting
        'initializing the array'


        obj.num = 0
        obj.artist_name = "vanguk"
        obj.title = "sun_flower"
        obj.price = 600
        obj.rank = 9
        obj.sold_status = "200"

        paint_list.Add(obj)



        obj.num = 1
        obj.artist_name = "david"
        obj.title = "flower"
        obj.price = 1000
        obj.rank = 7
        obj.sold_status = "sold out"

        paint_list.Add(obj)


        obj.num = 2
        obj.artist_name = "sorel"
        obj.title = "rain"
        obj.price = 1100
        obj.rank = 2
        obj.sold_status = "sold out"

        paint_list.Add(obj)


        obj.num = 3
        obj.artist_name = "Sami"
        obj.title = "moon"
        obj.price = 3000
        obj.rank = 8
        obj.sold_status = "2000$"

        paint_list.Add(obj)


        obj.num = 4
        obj.artist_name = "Yunis"
        obj.title = "farm"
        obj.price = 5000
        obj.rank = 7
        obj.sold_status = "6000$"

        paint_list.Add(obj)

        obj.num = 5
        obj.artist_name = "camil"
        obj.title = "tech"
        obj.price = 10000
        obj.rank = 8
        obj.sold_status = "20000$"

        paint_list.Add(obj)




        Console.WriteLine("   ")
        Console.WriteLine("   ")
        Console.WriteLine("*********************Welcome to Auction Menu*************************")
        Console.WriteLine("   ")
        Console.WriteLine("No." & vbTab & "Artist_name" & vbTab & "Painting_Title" & vbTab & "Price" & vbTab & "Rank" & vbTab & "Status")

        For i As Integer = 0 To paint_list.Count - 1

            Console.WriteLine(paint_list(i).num & vbTab & paint_list(i).artist_name & vbTab & "         " & paint_list(i).title & vbTab & "        " & paint_list(i).price & vbTab & paint_list(i).rank & vbTab & paint_list(i).sold_status)

        Next

        Console.WriteLine("**********************************************************************  ")
        Console.WriteLine("   ")


        'chooding action from menue

        Dim if_ex As Integer = 0
        Do
            Dim pass As String
            Console.WriteLine("to access the menu option enter the password")
            pass = Console.ReadLine

            Dim pass_word As String = "herzing22"
            If pass = pass_word Then



                Dim ex_out As Integer = 1
                Do
                    Dim act As Integer

                    Console.WriteLine("         ")
                    Console.WriteLine("*******************CHOSE ONE OF THE FOLLOWING OPTIONS******************")
                    Console.WriteLine("         ")
                    Console.WriteLine("type 1 to add a new item")
                    Console.WriteLine("type 2 to delete a new item")
                    Console.WriteLine("type 3 to edit an item")
                    Console.WriteLine("type 4 to display the list")
                    Console.WriteLine("type 5 to show minimum price and the maximum price of items")
                    Console.WriteLine("type 6 to find an item by its artist's name")
                    Console.WriteLine("type 7 to find an item by its title")
                    act = Console.ReadLine()


                    Select Case act

                        Case 1   'add item

                            Dim ex1 As Integer = 1
                            Do
                                Dim n As Integer = paint_list.Count

                                obj.num = n

                                Console.WriteLine("enter the artist's name of new item")
                                obj.artist_name = Console.ReadLine()

                                Console.WriteLine("enter the title  of new item")
                                obj.title = Console.ReadLine()


                                Do
                                    Console.WriteLine("enter the price of new item")
                                    obj.price = Console.ReadLine()
                                Loop Until IsNumeric(obj.price)

                                Do
                                    Console.WriteLine("enter the rank of new item")
                                    obj.rank = Console.ReadLine()
                                Loop Until IsNumeric(obj.rank)


                                Console.WriteLine("enter the status of new item")
                                obj.sold_status = Console.ReadLine()

                                paint_list.Add(obj)

                                Console.WriteLine("type 1 if you want to add the new item if not 0")
                                ex1 = Console.ReadLine()

                            Loop While ex1 = 1



                        Case 2     'delete item


                            Dim ex2 As Integer = 1
                            Do


                                Dim m As Integer
                                Console.WriteLine("enter  No. of the item you want to delete")
                                m = Console.ReadLine()

                                Dim z As Integer
                                For j As Integer = 0 To paint_list.Count - 1

                                    z = paint_list(j).num
                                    If z = m Then
                                        If paint_list(j).sold_status.Equals("sold out") = True Then
                                            Console.WriteLine("you could not delete this item, it is sold_out")
                                            Exit For ' terminate the For loop

                                        Else
                                            paint_list.RemoveAt(m)


                                        End If

                                        Exit For
                                    End If

                                Next

                                Dim w As Integer = paint_list.Count


                                For h As Integer = m To paint_list.Count - 1


                                    Dim temp As Integer = paint_list(h).num
                                    Dim temp1 As String = paint_list(h).artist_name
                                    Dim temp11 As String = paint_list(h).title
                                    Dim temp111 As Integer = paint_list(h).price
                                    Dim temp1111 As Integer = paint_list(h).rank
                                    Dim temp11111 As String = paint_list(h).sold_status


                                    obj.num = temp - 1
                                    obj.artist_name = temp1
                                    obj.title = temp11
                                    obj.price = temp111
                                    obj.rank = temp1111
                                    obj.sold_status = temp11111


                                    paint_list.Add(obj)


                                Next


                                Dim w1 As Integer = paint_list.Count


                                For a As Integer = 0 To w1 - w - 1
                                    paint_list.RemoveAt(m)
                                Next










                                Console.WriteLine("type 1 if you want to delete the new item if not 0")
                                ex2 = Console.ReadLine()



                            Loop While ex2 = 1






                        Case 3           'edit item's price or status



                            Dim choose As String
                            Console.WriteLine("if you want to edit  the price type price if the status type status")
                            choose = Console.ReadLine()

                            Dim ex6 As Integer = 1
                            Do

                                Dim n As Integer
                                Console.WriteLine("enter the item's number you wish to edit")
                                n = Console.ReadLine()






                                If paint_list(n).sold_status.Equals("sold out") = True Then
                                    Console.WriteLine("you could not delete this item, it is sold_out")


                                Else

                                    Select Case choose
                                        Case "price"

                                            Dim w As Integer = paint_list.Count
                                            Dim p As Integer
                                            Console.WriteLine("type the new price")
                                            p = Console.ReadLine()



                                            Dim temp As Integer = paint_list(n).num
                                            Dim temp1 As String = paint_list(n).artist_name
                                            Dim temp11 As String = paint_list(n).title
                                            Dim temp111 As Integer = paint_list(n).price
                                            Dim temp1111 As Integer = paint_list(n).rank
                                            Dim temp11111 As String = paint_list(n).sold_status


                                            obj.num = temp
                                            obj.artist_name = temp1
                                            obj.title = temp11
                                            obj.price = p
                                            obj.rank = temp1111
                                            obj.sold_status = temp11111


                                            paint_list.Add(obj)


                                            For i As Integer = n + 1 To w - 1

                                                Dim t1 As Integer = paint_list(i).num
                                                Dim t2 As String = paint_list(i).artist_name
                                                Dim t3 As String = paint_list(i).title
                                                Dim t4 As Integer = paint_list(i).price
                                                Dim t5 As Integer = paint_list(i).rank
                                                Dim t6 As String = paint_list(i).sold_status

                                                obj.num = t1
                                                obj.artist_name = t2
                                                obj.title = t3
                                                obj.price = t4
                                                obj.rank = t5
                                                obj.sold_status = t6

                                                paint_list.Add(obj)
                                            Next


                                            Dim w1 As Integer = paint_list.Count
                                            For a As Integer = 0 To w1 - w - 1
                                                paint_list.RemoveAt(n)
                                            Next







                                        Case "status"

                                            Dim w As Integer = paint_list.Count
                                            Dim stat As String
                                            Console.WriteLine("type the new status")
                                            stat = Console.ReadLine()

                                            Dim temp As Integer = paint_list(n).num
                                            Dim temp1 As String = paint_list(n).artist_name
                                            Dim temp11 As String = paint_list(n).title
                                            Dim temp111 As Integer = paint_list(n).price
                                            Dim temp1111 As Integer = paint_list(n).rank
                                            Dim temp11111 As String = paint_list(n).sold_status


                                            obj.num = temp
                                            obj.artist_name = temp1
                                            obj.title = temp11
                                            obj.price = temp111
                                            obj.rank = temp1111
                                            obj.sold_status = stat


                                            paint_list.Add(obj)


                                            For i As Integer = n + 1 To w - 1

                                                Dim t1 As Integer = paint_list(i).num
                                                Dim t2 As String = paint_list(i).artist_name
                                                Dim t3 As String = paint_list(i).title
                                                Dim t4 As Integer = paint_list(i).price
                                                Dim t5 As Integer = paint_list(i).rank
                                                Dim t6 As String = paint_list(i).sold_status

                                                obj.num = t1
                                                obj.artist_name = t2
                                                obj.title = t3
                                                obj.price = t4
                                                obj.rank = t5
                                                obj.sold_status = t6

                                                paint_list.Add(obj)
                                            Next

                                            Dim w1 As Integer = paint_list.Count

                                            For a As Integer = 0 To w1 - w - 1
                                                paint_list.RemoveAt(n)
                                            Next




                                    End Select


                                End If


                                Console.WriteLine("do you want to edit another item? if yes type 1 else 0")
                                ex6 = Console.ReadLine()



                            Loop While ex6 = 1






                        Case 4                'display items




                            Console.WriteLine("   ")
                            Console.WriteLine("   ")
                            Console.WriteLine("*********************Desplay the Auction Menu*************************")
                            Console.WriteLine("   ")
                            Console.WriteLine("=====================================================================================================")
                            Console.WriteLine("No." & vbTab & "Artist_name" & vbTab & "Painting_Title" & vbTab & "Price" & vbTab & "Rank" & vbTab & "Status")

                            For i As Integer = 0 To paint_list.Count - 1

                                Console.WriteLine(paint_list(i).num & vbTab & paint_list(i).artist_name & vbTab & "         " & paint_list(i).title & vbTab & "        " & paint_list(i).price & vbTab & paint_list(i).rank & vbTab & paint_list(i).sold_status)

                            Next
                            Console.WriteLine("=====================================================================================================")







                        Case 5                   'max and min the price






                            For i As Integer = 0 To (paint_list.Count - 1)

                                For j As Integer = paint_list.Count - 1 To (i)



                                    If paint_list(j).price < paint_list(j - 1).price Then

                                        Dim temp1 As Integer = paint_list(j).price
                                        Dim temp11 As Integer = paint_list(j).num
                                        Dim temp111 As String = paint_list(j).artist_name
                                        Dim temp1111 As String = paint_list(j).title
                                        Dim temp11111 As Integer = paint_list(j).rank
                                        Dim temp111111 As String = paint_list(j).sold_status



                                        Dim temp As Integer = paint_list(j - 1).price
                                        Dim temp0 As Integer = paint_list(j - 1).num
                                        Dim temp00 As String = paint_list(j - 1).artist_name
                                        Dim temp000 As String = paint_list(j - 1).title
                                        Dim temp0000 As Integer = paint_list(j - 1).rank
                                        Dim temp00000 As String = paint_list(j - 1).sold_status






                                        obj.num = temp0
                                        obj.artist_name = temp00
                                        obj.title = temp000
                                        obj.price = temp
                                        obj.rank = temp0000
                                        obj.sold_status = temp00000

                                        paint_list.RemoveAt(j)
                                        paint_list.Add(obj)

                                        obj.num = temp11
                                        obj.artist_name = temp111
                                        obj.title = temp1111
                                        obj.price = temp1
                                        obj.rank = temp11111
                                        obj.sold_status = temp111111

                                        paint_list.RemoveAt(j - 1)
                                        paint_list.Add(obj)


                                    End If
                                Next
                            Next

                            Dim arr(paint_list.Count) As Integer
                            arr(0) = 0
                            If paint_list(0).sold_status.Equals("sold out") = True Then
                                For u As Integer = 1 To paint_list.Count - 1
                                    If paint_list(u).sold_status.Equals("sold out") = True Then
                                        arr(u) = 1
                                    Else
                                        arr(u) = 0
                                    End If

                                Next

                                Dim g As Integer
                                For g = 1 To arr.Length - 1
                                    If arr(g) = 1 Then
                                        Dim K As Integer = g
                                    End If
                                Next


                                Console.WriteLine("the minimum price is:")
                                Console.WriteLine(paint_list(g).num & vbTab & paint_list(g).artist_name & vbTab & "         " & paint_list(g).title & vbTab & "        " & paint_list(g).price & vbTab & paint_list(g).rank & vbTab & paint_list(g).sold_status)

                            Else

                                Console.WriteLine("the minimum price is:")
                                Console.WriteLine(paint_list(0).num & vbTab & paint_list(0).artist_name & vbTab & "         " & paint_list(0).title & vbTab & "        " & paint_list(0).price & vbTab & paint_list(0).rank & vbTab & paint_list(0).sold_status)

                            End If






                            Dim s As Integer = paint_list.Count - 1
                            Dim arr_1(paint_list.Count) As Integer
                            arr_1(paint_list.Count - 1) = 0
                            If paint_list(s).sold_status.Equals("sold out") = True Then
                                For u1 As Integer = s - 2 To 0
                                    If paint_list(u1).sold_status.Equals("sold out") = True Then
                                        arr(u1) = 1
                                    Else
                                        arr(u1) = 0
                                    End If

                                Next


                                Dim K1 As Integer
                                Dim g1 As Integer
                                For g1 = arr.Length - 1 To 0
                                    If arr(g1) = 1 Then
                                        K1 = g1
                                    End If
                                Next

                                Console.WriteLine("the maximum price is:")
                                Console.WriteLine(paint_list(g1).num & vbTab & paint_list(g1).artist_name & vbTab & "         " & paint_list(g1).title & vbTab & "        " & paint_list(g1).price & vbTab & paint_list(g1).rank & vbTab & paint_list(g1).sold_status)




                            Else

                                Console.WriteLine("the maximum price is:")
                                Console.WriteLine(paint_list(s).num & vbTab & paint_list(s).artist_name & vbTab & "         " & paint_list(s).title & vbTab & "        " & paint_list(s).price & vbTab & paint_list(s).rank & vbTab & paint_list(s).sold_status)
                            End If





                        Case 6                    'find items by artist name 


                            Dim ex_3 As Integer = 1

                            Do
                                Dim name As String
                                Console.WriteLine("enter the artist's name")
                                name = Console.ReadLine()


                                Dim arr_2(paint_list.Count - 1) As Integer
                                For i As Integer = 0 To paint_list.Count - 1
                                    If paint_list(i).artist_name.Equals(name) = True Then
                                        arr_2(i) = 1

                                    Else
                                        arr_2(i) = 0

                                    End If

                                Next


                                For j As Integer = 0 To arr_2.Length - 1
                                    If arr_2(j) = 1 Then
                                        Console.WriteLine(paint_list(j).num & vbTab & paint_list(j).artist_name & vbTab & "         " & paint_list(j).title & vbTab & "        " & paint_list(j).price & vbTab & paint_list(j).rank & vbTab & paint_list(j).sold_status)

                                    End If


                                Next


                                Console.WriteLine("if you want to search for new name type 1 else 0")
                                ex_3 = Console.ReadLine()

                            Loop While ex_3 = 1




                        Case 7                     'find item by title



                            Dim ex_4 As Integer = 1

                            Do
                                Dim titr As String
                                Console.WriteLine("enter the title")
                                titr = Console.ReadLine()

                                Dim arr_1(paint_list.Count - 1) As Integer
                                For i As Integer = 0 To paint_list.Count - 1
                                    If paint_list(i).title.Equals(titr) = True Then
                                        arr_1(i) = 1

                                    Else
                                        arr_1(i) = 0

                                    End If

                                Next


                                For j As Integer = 0 To arr_1.Length - 1
                                    If arr_1(j) = 1 Then
                                        Console.WriteLine(paint_list(j).num & vbTab & paint_list(j).artist_name & vbTab & "         " & paint_list(j).title & vbTab & "        " & paint_list(j).price & vbTab & paint_list(j).rank & vbTab & paint_list(j).sold_status)

                                    End If


                                Next


                                Console.WriteLine("if you want to search for new title type 1 else 0")
                                ex_4 = Console.ReadLine()

                            Loop While ex_4 = 1






                        Case Else

                            Console.WriteLine("invalid enter")

                    End Select



                    Console.WriteLine("type 1 if you want to return to the main menu  if not 0")
                    ex_out = Console.ReadLine()

                Loop While ex_out = 1


                Console.WriteLine("   ")
                Console.WriteLine("   ")
                Console.WriteLine("*********************GOODBYE***************************")
                Console.WriteLine("   ")

            Else


                Console.WriteLine("your pasword is wrong, try again")
                if_ex = 1

            End If



        Loop While if_ex = 1


    End Sub
End Module
