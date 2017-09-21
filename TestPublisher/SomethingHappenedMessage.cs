using System;
using Contracts;

namespace TestPublisher
{
  public class SomethingHappenedMessage : ISomethingHappened
  {
    public string What { get; set; }
    public DateTime When { get; set; }
  }
}