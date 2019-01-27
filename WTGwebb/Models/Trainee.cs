
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Trainee
{



    public int ID { get; set; }

    public String Password { get; set; }

    public String FirstName;

    public String LastName;

    public String Email;

    public String PhoneNumber;

    public Trainee()
    {
    }

    public void Trainee(int id, String password, String firstName, String lastName, String email) : this(id, password, firstName, lastName, email,"null") 
{
    }
    public void Trainee(int id, String password, String firstName, String lastName, String email, String phoneNumber)
    {
        this.ID = id;
        this.Password = password;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Email = email;
        this.PhoneNumber = phoneNumber;
    }
}