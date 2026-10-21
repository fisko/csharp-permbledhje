int viti = 2024;

bool iBrishte = (viti % 4 == 0 && viti % 100 != 0)
                || (viti % 400 == 0);

Console.WriteLine(iBrishte ? "I brishtë" : "I zakonshëm");
