///Diagnose code:

	///For loop through numbers 1 to 100
	for (int i = 1; i <= 100; i++)
	{
				///Logic to replace numbers divisible by 2 and 7
        if (i % 2 == 0 & i % 7 == 0)
        {
        	///Logic to replace number with "Diagnose Patient" string
           Console.WriteLine("Diagnose Patient");
        }
        ///Logic to identify numbers divisible by 2
        else if (i % 2 == 0)
        {
        	///Logic to replace number with "Diagnose" string
          Console.WriteLine("Diagnose");
        }
        ///Logic to replace numbers divisible by 7
        else if (i % 7 == 0)
        {
        	///Logic to replace number with "Patient" string
          Console.WriteLine("Patient");
        }

        else 
        {
        ///Logic to print number
		    Console.WriteLine(i);
        }
	}	

///Pass criteria:
	/// * Numbers begin at 1 and end at 100
		/// * For multiples of two print "Diagnose" instead of the number
		/// * For the multiples of seven print "Patient" instead of the number
		/// * For numbers which are multiples of both two and seven print "Diagnose Patient" instead of the number