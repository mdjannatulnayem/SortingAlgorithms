//CLASS DEFINITION

#ifndef ALGORITHMS_H
#define ALGORITHMS_H

class Algorithms{

    public:
        //PUBLIC METHODS
    static int binarySearch(int arr[],int n,int elem);

    static void bubbleSort(int arr[],int n);

    static void selectionSort(int arr[],int n);

    static void insertionSort(int arr[],int n);

    static void quickSort(int arr[],int start,int end);

    static void mergeSort(int arr[],int start,int end);

    private:
        //INNER FUNCTIONALITIES
    int partition(int arr[],int start,int end);

    void conquer(int arr[],int start,int mid,int end);

    void divide(int arr[],int start,int end);

};

#endif //ALGORITHMS_H
