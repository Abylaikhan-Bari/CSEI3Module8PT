using System;

public class RangeOfArray
{
    private int lowerBound; // Нижний индекс допустимого диапазона
    private int upperBound; // Верхний индекс допустимого диапазона
    private int[] array;    // Массив для хранения данных

    // Конструктор класса, инициализирующий диапазон и массив
    public RangeOfArray(int lower, int upper)
    {
        lowerBound = lower;
        upperBound = upper;
        array = new int[upper - lower + 1];
    }

    // Индексатор, который позволяет получать и устанавливать элементы массива
    public int this[int index]
    {
        get
        {
            if (IsIndexValid(index))
            {
                return array[index - lowerBound];
            }
            else
            {
                throw new IndexOutOfRangeException("Индекс вне допустимого диапазона");
            }
        }
        set
        {
            if (IsIndexValid(index))
            {
                array[index - lowerBound] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Индекс вне допустимого диапазона");
            }
        }
    }

    // Метод для проверки, находится ли индекс в допустимом диапазоне
    private bool IsIndexValid(int index)
    {
        return index >= lowerBound && index <= upperBound;
    }
}
