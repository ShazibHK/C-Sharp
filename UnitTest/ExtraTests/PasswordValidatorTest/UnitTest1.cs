using System;
using Xunit;
using Validators.Password;

namespace PasswordValidatorTests
{
  public class ValidityTest
  {
    [Fact]
    public void ValidPassword()
    {
      //Arrange
      var passwordValidator = new PasswordValidator();
      const string password = "Th1sIsapassword!";

      //Act
      bool isValid = passwordValidator.IsValid(password);

      //Assert
      Assert.True(isValid, $"The password {password} is not valid");
    }
  }
}