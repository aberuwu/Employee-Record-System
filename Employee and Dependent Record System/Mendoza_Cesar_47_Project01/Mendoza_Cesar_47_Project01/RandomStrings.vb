Public Class RandomStrings
    Shared rand As System.Random = New System.Random()
    Shared randomInt As Integer

    Public Shared Function RandomFirstName() As String
        Static firstNames() As String = {"Anderson", "Oswaldo", "Valentino", "Odin", "Malaki", "Whitney", "Peter", "Maryjane", "Darrell", "Wendy", "Alfonso", "Tyson", "Talon", "Skyla", "Kimora", "Perla", "Dorian", "Thaddeus", "Elias", "Tyrone", "Samson", "Virginia", "Messiah", "Nathan", "Serenity", "Dean", "Simon", "Alex", "Hailie", "Emanuel",
            "Kianna", "Emilie", "Marlie", "Rubi", "Rowan", "Landin", "Raven", "Fletcher", "Ayden", "Angela", "Nathaly", "Gabriela", "Thomas", "Guadalupe", "Ainsley", "Javon", "Adriel", "Diya", "Cecelia", "Karli", "Jasmine", "Jayla", "Nasir", "Jacey", "Gauge", "Walker", "Rachel", "Ezekiel", "Carter", "Brooke",
            "Kelvin", "Adeline", "Deborah", "Kyson", "Nylah", "Titus", "Cassie", "Ada", "Issac", "Andrew", "Abraham", "Janiya", "Seth", "Kaylynn", "Diego", "Heidy", "Ryland", "Sophie", "Elizabeth", "Katelynn", "Keegan", "Salvador", "Neil", "Jamir", "Isaiah", "Trevon", "Alyvia", "Madeline", "Darian", "Addyson",
            "Callie", "Nayeli", "Janessa", "Maya", "Sammy", "Baylee", "Dominic", "Darius", "Wesley", "Jean", "Alana", "Reese", "Chandler", "Kristopher", "Lea", "Tobias", "Caleb", "Aidyn", "Derick", "Harper", "Myles", "Abril", "Lena", "Addisyn", "Jaidyn", "Lilian", "Jack", "Ariana", "Maeve", "Dane",
            "Zaria", "Isaias", "Destiny", "Janae", "Vanessa", "Ciara", "Joslyn", "Payton", "Ian", "Cristopher", "Darnell", "Anne", "Giovanni", "Mark", "Hector", "Karter", "Nikolas", "James", "Sherlyn", "Maia", "Kennedy", "Justice", "Brendan", "Trinity", "Mireya", "Riley", "Cooper", "Tabitha", "Sonny", "Jarrett",
            "Janet", "Leyla", "Jade", "Martha", "Paul", "Alina", "Dalton", "Lizbeth", "Keenan", "Derrick", "Michael", "Edith", "Lennon", "Barrett", "Mya", "Kaylah", "Leon", "Aiyana", "Leonel", "Cash", "Simone", "Genevieve", "Braylon", "Adyson", "Abbie", "Kiersten", "Brayden", "Karly", "Grace", "Ramiro",
            "Dana", "Britney", "Jordyn", "Kolby", "Johan", "Hailey", "Rayne", "Aditya", "Jovanni", "Kali", "Laci", "Rosa", "Mayra", "Zariah", "Terrell", "Randy", "August", "Collin", "Livia", "Kyler", "Ismael", "Leia", "Jerry", "Areli", "Lailah", "Guillermo", "Samir", "Kayley", "Charlie", "Brielle",
            "Ty", "Aniyah", "Gavin", "Kason", "Kelly", "Rory", "Romeo", "Ellie", "Leandro", "Cale", "Demarcus", "Mila", "Kira", "Fisher", "Gordon", "Jaden", "Arianna", "Lia", "Erika", "Luis", "Kaleigh", "Shirley", "Willie", "Tiana", "Rocco", "Justine", "Crystal", "Jocelyn", "Denzel", "Braylen",
            "Aiden", "Nehemiah", "Toby", "Easton", "Karlie", "Arabella", "Jaylen", "Marley", "Catalina", "Monserrat", "Davin", "Larissa", "Bailey", "Briana", "Jaylin", "Kyra", "Magdalena", "Yadira", "Lacey", "Gilbert", "Aleena", "Diamond", "Dallas", "Brianna", "Joy", "Killian", "Alexandria", "Devon", "Holden", "Carley",
            "Campbell", "Paxton", "Lindsey", "Marquis", "Tanner", "Ayla", "Abdiel", "Tyree", "Liana", "Krista", "Gabriel", "Kiera", "Kaden", "Amelie", "Alexia", "Mariah", "Kara", "Kirsten", "Semaj", "Fernando", "Jessica", "Jamiya", "Deshawn", "Arthur", "Tommy", "Hayden", "Damari", "Nash", "Ivan", "Jayleen"}


        Return firstNames(rand.Next(0, firstNames.Length - 1))
    End Function

    Public Shared Function RandomLastName() As String

        Static lastNames() As String = {"Jarvis", "Bryan", "Herring", "Lam", "Eaton", "Doyle", "Hudson", "Gutierrez", "Mathews", "Daniels", "Smith", "Pitts", "Carpenter", "Moses", "Conrad", "Deleon", "Mayer", "Wang", "Bruce", "Booker", "Bird", "Thompson", "Hunt", "Wilkinson", "Callahan", "Black", "Davila", "Davies", "Hicks", "Irwin",
                "Peck", "Lucas", "Horton", "Clark", "Garrison", "Mack", "Hull", "Mooney", "Richardson", "Woodard", "Choi", "Shah", "Buchanan", "Gonzales", "Pineda", "Griffith", "Glenn", "Wolf", "Bartlett", "Norris", "Guerrero", "Raymond", "Hurst", "Mendez", "Mueller", "Blackburn", "Estrada", "Monroe", "Nunez", "Craig",
                "Freeman", "Hart", "Proctor", "Schmidt", "Pruitt", "Villegas", "Peters", "Hunter", "Douglas", "Gill", "Blanchard", "Holmes", "Weaver", "Neal", "Fitzpatrick", "Gilmore", "Edwards", "Dickerson", "Hayden", "Hebert", "Nash", "Hays", "Elliott", "Rowe", "Rosario", "Donaldson", "Hansen", "Santiago", "Allen", "Maddox",
                "Sullivan", "Wong", "Bishop", "Sanders", "Norman", "Kirk", "Cunningham", "Cohen", "Hogan", "Hinton", "Cline", "Charles", "Shaffer", "Christian", "Marshall", "Hensley", "Huber", "Huerta", "Lynch", "Whitney", "Hester", "Larsen", "Khan", "Ramirez", "Jordan", "Frazier", "Mccarty", "Chen", "Farmer", "Meyer",
                "Ho", "Hess", "Armstrong", "Blankenship", "Winters", "Chambers", "Herrera", "Wells", "Huang", "Mills", "Gilbert", "Crane", "Mcdowell", "Middleton", "Rice", "Aguilar", "Mcintosh", "Ross", "Hendrix", "Madden", "Schaefer", "Richards", "Clay", "Blackwell", "Ashley", "Rangel", "Fry", "Camacho", "Blevins", "Hale",
                "Key", "Parks", "Leach", "Velasquez", "Morrow", "Everett", "Williamson", "Cordova", "Pace", "Dickson", "Roman", "Robbins", "Villa", "Sandoval", "Beltran", "Salas", "White", "Medina", "Preston", "Perry", "Spears", "Farrell", "Baker", "Logan", "Williams", "Hardy", "Nelson", "Kaufman", "Cowan", "Parsons",
                "Griffin", "Coffey", "Merritt", "Mays", "Harrell", "Le", "Galloway", "Bowen", "Horne", "Floyd", "Miles", "Steele", "Fowler", "Combs", "Yang", "Perkins", "Werner", "Knapp", "Olson", "Stewart", "Brock", "Hobbs", "Best", "Bean", "Cabrera", "Blake", "Zimmerman", "Stokes", "Humphrey", "Sparks",
                "Howard", "Golden", "Salazar", "Alvarado", "Hines", "Drake", "Oneill", "Decker", "Conway", "Walters", "Frye", "Barber", "Ellison", "Arnold", "Singh", "Branch", "English", "Lyons", "Soto", "Mckenzie", "Rosales", "Levy", "Hernandez", "Mccormick", "Cantrell", "Levine", "Welch", "Zhang", "Stone", "Woodward",
                "Fletcher", "Barrera", "Harrison", "Bass", "Valencia", "Reed", "Hubbard", "Gonzalez", "Thomas", "Goodman", "Fuentes", "Harding", "Anderson", "Martin", "Tate", "Acosta", "Mcconnell", "Ibarra", "Brooks", "Lozano", "Mccall", "Fleming", "Lindsey", "Lara", "Harmon", "Jefferson", "Meyers", "Mann", "Zuniga", "Gallagher",
                "Ingram", "Barrett", "Barker", "Roy", "Villarreal", "Lee", "Romero", "Mcbride", "Reynolds", "Larson", "Maynard", "Mccarthy", "Franklin", "Krueger", "Kim", "Holder", "Tyler", "Murillo", "Lowe", "Randall", "Arroyo", "Wilson", "Lawson", "Flynn", "Olsen", "Ayers", "Wolfe", "Durham", "Gibbs", "Bond"
}


        Return lastNames(rand.Next(0, lastNames.Length - 1))
    End Function

    Public Shared Function RandomMiddleName() As String
        randomInt = rand.Next(1, 100)

        If randomInt <= 30 Then
            Return RandomStrings.RandomFirstName().Substring(0, 1)
        ElseIf randomInt <= 80 Then
            Return RandomStrings.RandomFirstName()
        Else
            Return ""
        End If
    End Function

    Public Shared Function RandomChicagoAreaCode() As String


        Static areaCodes() As String = {"630", "630", "630", "630", "847", "847", "708", "708", "815", "312", "331"}

        Return areaCodes(rand.Next(0, areaCodes.Length - 1))
    End Function

    Public Shared Function RandomEmployeeNumber() As String
        Return rand.Next(1, 999999).ToString("000000")
    End Function

    Public Shared Function RandomSsn() As String
        Return rand.Next(200, 999).ToString("000") & "-" & rand.Next(0, 99).ToString("00") & "-" & rand.Next(0, 9999).ToString("0000")
    End Function

    Public Shared Function RandomBirthDateEmpOrSpouse() As DateTime
        Return DateTime.Now.AddYears(-65).AddDays(rand.Next(0, 40 * 365 + 10))
    End Function

    Public Shared Function RandomBirthDateChild() As DateTime
        Return DateTime.Now.AddYears(-65).AddDays(rand.Next(0, 40 * 365 + 10))
    End Function

    Public Shared Function RandomHireDate() As DateTime
        Return DateTime.Now.AddYears(-16).AddDays(rand.Next(0, 16 * 365)).ToString("yyyyMMdd")
    End Function

    Public Shared Function RandomWorkPhone() As String
        Return "630-555-9" & rand.Next(0, 999).ToString("000")
    End Function

    Public Shared Function RandomPersonalPhone() As String
        randomInt = rand.Next(1, 100)
        If randomInt <= 50 Then
            Return RandomStrings.RandomChicagoAreaCode() & "-" & rand.Next(200, 999).ToString("000") & "-" & rand.Next(0, 9999).ToString("0000")
        Else
            Return ""
        End If
    End Function

    Public Shared Function RandomPersonalMobilePhone() As String
        randomInt = rand.Next(1, 100)
        If randomInt <= 75 Then
            Return RandomStrings.RandomChicagoAreaCode() & "-" & rand.Next(200, 999).ToString("000") & "-" & rand.Next(0, 9999).ToString("0000")
        Else
            Return ""
        End If
    End Function

    Public Shared Function WorkEmail(FirstName As String, LastName As String) As String
        Return FirstName & "." & LastName.ToLower() & "@example.com"
    End Function

    Public Shared Function PersonalEmail(FirstName As String, LastName As String) As String
        randomInt = rand.Next(1, 100)
        If randomInt <= 50 Then
            Return FirstName.ToLower() & LastName.Substring(0, 1).ToLower() & rand.Next(0, 300) & "@example.net"
        Else
            Return ""
        End If
    End Function

    Public Shared Function RandomFullTimeAnnualSalary() As String
        Return rand.Next(40000, 400000).ToString("N2")
    End Function

    Public Shared Function RandomFullTimeHourlySalary() As String
        Return (rand.NextDouble() * 30 + 16.25).ToString("N2")
    End Function

    Public Shared Function RandomPartTimeHourlySalary() As String
        Return (rand.NextDouble() * 10 + 9.25).ToString("N2")
    End Function

    Public Shared Function RandomOfficeLocation() As String
        Return rand.Next(0, 9) & Chr(65 + rand.Next(0, 9)) & rand.Next(0, 999).ToString("000")
    End Function
End Class
