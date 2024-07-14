
public class ArraySearchOperation{
    
int [] arr1 = [2,3,6,1,5,1,4];

public void searchMinAndMax(){

 var arrResult1=sortArrayBySingleLoop(arr1);
 var arrResult=sortArrayBySelectionSort(arr1);

 Console.WriteLine("Min data: {0}",arrResult[0]);
 Console.WriteLine("Max data: {0}",arrResult[arr1.Length-1]);

}

public int[] sortArrayBySingleLoop(int[] arr){

   int length=arr.Length;

   for(int i =0;i<length-1;i++){
     
     if(arr[i] > arr[i+1]){
        int temp = arr[i];
        arr[i] = arr[i+1];
        arr[i+1] = temp;
        i=-1;
     }

   }

     return arr;

}

public int[] sortArrayBySelectionSort(int[] arr){
   int n=arr.Length;
   for(int i=0;i<n;i++){
    for(int j=i+1;j<n;j++){
        if(arr[i]>arr[j]){
            int temp = arr[j];
            arr[j]=arr[i];
            arr[i]=temp;
        }
    }
   }
    return arr;
}

}