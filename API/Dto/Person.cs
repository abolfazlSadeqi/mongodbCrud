﻿namespace API.Dto;

public class PersonDto
{

   
    public string ID { set; get; }
    public string FirstName { set; get; }
    public string LastName { set; get; }
    public string Suffix { set; get; }
    public string Email { set; get; }
    public string AdditionalContactInfo { set; get; }
    public DateTime ModifiedDate { set; get; }
    public DateTime CreateDate { set; get; }


}