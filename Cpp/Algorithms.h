//CLASS DEFINITION

#ifndef ALGORITHMS_H
#define ALGORITHMS_H

class Algorithms{

    public:
        //PUBLIC METHODS
    int binarySearch(int arr[],int n,int elem);

    void bubbleSort(int arr[],int n);

    void selectionSort(int arr[],int n);

    void insertionSort(int arr[],int n);

    void quickSort(int arr[],int start,int end);

    void mergeSort(int arr[],int start,int end);

    private:
        //INNER FUNCTIONALITIES
    int partition(int arr[],int start,int end);

    void conquer(int arr[],int start,int mid,int end);

    void divide(int arr[],int start,int end);

};

#endif //ALGORITHMS_H
