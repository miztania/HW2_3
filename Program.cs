using System;

class Program{
    static void Main(string[] args){
        while(true){
            Console.Write("Enter Oparation : ");
            string operation = Console.ReadLine();

            if("+-".Contains(operation)){
                Console.Write("Enter Size of row : ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Enter Size of colum : ");
                int colum = int.Parse(Console.ReadLine());

                float[,] matrix1 = new float[row,colum];
                float[,] matrix2 = new float[row,colum];
                float[,] sumMatrix = new float[row,colum];

                //Get Matrix 1
                for(int i = 0; i < row ; i++){
                    for(int j = 0 ; j < colum ; j++){
                        Console.Write("Matrix1"+"["+(i+1)+","+(j+1)+"] : ");
                        matrix1[i,j] =  float.Parse(Console.ReadLine());
                    }
                }

                //Get Matrix 2 
                for(int i = 0; i < row ; i++){
                    for(int j = 0 ; j < colum ; j++){
                        Console.Write("Matrix2"+"["+(i+1)+","+(j+1)+"] : ");
                        matrix2[i,j] =  float.Parse(Console.ReadLine());
                    }
                }
                
              //  ShowMatrix(matrix1,row,colum);
              //  ShowMatrix(matrix2,row,colum);

                //Operation Matrix 

                if(operation == "+"){
                    for(int i = 0; i < row ; i++){
                         for(int j = 0 ; j < colum ; j++){
                            sumMatrix[i,j] =  matrix1[i,j] + matrix2[i,j];
                          }
                    }
                }else if (operation == "-"){
                     for(int i = 0; i < row ; i++){
                         for(int j = 0 ; j < colum ; j++){
                            sumMatrix[i,j] =  matrix1[i,j] - matrix2[i,j];
                          }
                     }
                } 
                  
                //Answer
               // Console.WriteLine("Operator : " + operation);
                ShowMatrix(sumMatrix,row,colum);

            }else{
              //  Console.WriteLine("End");
                break;
            }
        }
        
    }

    static void ShowMatrix(float[,] matrix , int row, int colum){
         // Console.WriteLine("Show Matrix");

                for(int i = 0; i < row ; i++){
                    for(int j = 0 ; j < colum ; j++){
                        Console.Write(matrix[i,j]+" ");
                    }
                    Console.WriteLine();
                }
    }



 

}
