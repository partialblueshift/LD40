using UnityEngine;

public class BankAccount
{
    public int Balance { get; private set; }

    public BankAccount() { }

    public void Add(int amount)
    {
        Balance += amount;
    }

    public void Remove(int amount)
    {
        Balance -= amount;
    }
}