///Register code:

	///For loop through numbers 1 to 100
	for (int i = 1; i <= 100; i++)
	{
				///Logic to replace numbers divisible by 3 and 5
        if (i % 3 == 0 & i % 5 == 0)
        {
        	///Logic to replace number with "Register Patient" string
           Console.WriteLine("Register Patient");
        }
        ///Logic to identify numbers divisible by 3
        else if (i % 3 == 0)
        {
        	///Logic to replace number with "Register" string
          Console.WriteLine("Register");
        }
        ///Logic to replace numbers divisible by 5
        else if (i % 5 == 0)
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
		/// * For multiples of three print "Register" instead of the number
		/// * For the multiples of five print "Patient" instead of the number
		/// * For numbers which are multiples of both three and five print "Register Patient" instead of the number