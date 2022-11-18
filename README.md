# GenomeCalculator
A nuget package that reads .fasta files and do some bioinformatic calculations.


This class library reads fasta or any textfile that contains a DNA sequence.
The nuget calculates a gene's GC composition, helpful to determine the gene's quality.
Also the sequence's baselength can calculated.


Examples



            Example: 1 ==> Generate the basepairlength
            
            string filepath = @"C:\Users\...\sequence.fasta";
            Context myDNA = new Context(operation: new Length());
            double result = myDNA.execute(filepath);
            Console.WriteLine("DNA ==> " + result );
            
            
            Example: 2 ==> Generate the GC ration
            
            string filepath = @"C:\Users\...\sequence.fasta";
            Context myDNA = new Context(operation: new Ratio());
            double result = myDNA.execute(filepath);
            Console.WriteLine("DNA ==> " + result );
