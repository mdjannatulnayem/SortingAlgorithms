//CLASS DEFINITION

#include <iostream>
#ifndef ALGORITHMS_H
#define ALGORITHMS_H

template <class U>
class Algorithms{

    private:
        //INNER FUNCTIONALITIES
    int partition(U arr[],int start,int end){
        int i=start-1;
        for(int j=start;j<end;j++){
            if(arr[j]<arr[end]){
                i++;
                std::swap(arr[i],arr[j]);
            }
        }
        i++;
        std::swap(arr[i],arr[end]);
        return i;
    }
    
    void divide(U arr[],int start,int end){
        if(start>=end){
            return;
        }
        int mid = start+(end-start)/2;
        divide(arr,start,mid);
        divide(arr,mid+1,end);
        conquer(arr,start,mid,end);
    }

    void conquer(U arr[],int start,int mid,int end){
        int len = end-start+1;
        U merged[len];
        int x=0,index1=start,index2=mid+1;
        while (index1<=mid && index2<=end)
        {
            if(arr[index1]<=arr[index2]){
                merged[x++]=arr[index1++];
            }else{
                merged[x++]=arr[index2++];
            }
        }

        while(index1<=mid){
            merged[x++]=arr[index1++];
        }

        while(index2<=end){
            merged[x++]=arr[index2++];
        }

        for(int i=0,j=start;i<(sizeof(merged)/sizeof(merged[0]));i++,j++){
            arr[j]=merged[i];
        }
    }
    

    public:
        //PUBLIC METHODS
    static int binarySearch(U arr[],int n,int elem){
        int mid,start=0,end=n-1;
        while(start<=end){
            mid = start+(end-start)/2;
            if(elem==arr[mid]){
                return mid;
            }
            else if(elem<arr[mid]){
                end=mid-1;
            }
            else{
                start=mid+1;
            }
        }
        return -1;
    }

    static void bubbleSort(U arr[],int n){
        bool isSorted;
        for(int i=0;i<n;i++){
            isSorted=true;
            for(int j=1;j<n-i;j++){
                if(arr[j]<arr[j-1]){
                    std::swap(arr[j],arr[j-1]);
                    isSorted=false;
                }
            }
            if(isSorted){
                break;
            }
        }
    }

    static void selectionSort(U arr[],int n){
        int min;
        for(int i=0;i<n-1;i++){
            min=i;
            for(int j=i+1;j<n;j++){
                if(arr[j]<arr[min]){
                    min=j;
                }
            }
            std::swap(arr[min],arr[i]);
        }
    }

    static void insertionSort(U arr[],int n){
        int j;U current;
        for(int i=1;i<n;i++){
            j=i-1;
            current=arr[i];
            while(j>=0&&arr[j]>current){
                arr[j+1]=arr[j];
                j--;
            }
            arr[j+1]=current;
        }
    }

    static void quickSort(U arr[],int start,int end){
        if(start<end){
            int pivot=partition(arr,start,end);
            quickSort(arr,pivot+1,end);
            quickSort(arr,start,pivot-1);
        }
    }

    static void mergeSort(U arr[],int start,int end){
        divide(arr,start,end);
    }

};

#endif //ALGORITHMS_H
