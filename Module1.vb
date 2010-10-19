Imports System.Xml

Module Module1

    Sub Main()

        Try
            'Retrieve XML document   
            Dim reader As XmlTextReader = New XmlTextReader("http://weather.yahooapis.com/forecastrss?w=2353991")

            reader.Read()

            'Finds the tag 
            reader.ReadToFollowing("yweather:condition")

            'Finds and displays attribute
            Console.WriteLine(reader.GetAttribute("temp"))

        Catch ex As InvalidCastException
            Console.WriteLine("Invalid Data")

        Catch ex As Exception
            Console.WriteLine("Error occurred")

        End Try


    End Sub






End Module
