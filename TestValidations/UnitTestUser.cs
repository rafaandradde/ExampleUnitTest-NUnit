using FluentValidation.TestHelper;
using NUnit.Framework;
using UserValidation.Entities;
using UserValidation.Validations;

namespace TestValidations
{
    [TestFixture]
    public class Tests
    {
        private UserValidations validator;

        [SetUp]
        public void Setup()
        {
            validator = new UserValidations();
        }

        [Category("IdUser_Error")]
        [Description("Usuario de criaçao deve ser maior que zero")]
        [Test]
        public void Should_have_error_when_user_created_is_zero()
        {
            var model = new User { IdUser = 0 };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(User => User.IdUser);
        }

        [Category("Name_Error")]
        [Description("Deve ocorrer um erro caso o campo Nome nao for preenchido")]
        [Test]
        public void Should_have_error_when_FristName_is_empty()
        {
            var model = new User { FirstName = "" };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(User => User.FirstName);
        }


        [Category("Name_Error")]
        [Description("Deve ocorrer um erro caso o campo Nome Tiver menos que 3 letras")]
        [Test]
        public void Should_have_error_when_Length_FirstName_is_less_than_three()
        {
            var model = new User { FirstName = "Ra" };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(User => User.FirstName);
        }

        [Category("Name_Error")]
        [Description("Deve ocorrer um erro caso o campo Nome Tiver mais do que 10 letras")]
        [Test]
        public void Should_have_error_when_Length_FirstName_is_greater_than_ten()
        {
            var model = new User { FirstName = "Lorem Ipsum is simply dummy text" };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(User => User.FirstName);
        }

        [Category("Surname_Error")]
        [Description("Deve ocorrer um erro caso o campo Sobrenome nao for preenchido")]
        [Test]
        public void Should_have_error_when_Surname_is_empty()
        {
            var model = new User { Surname = "" };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(User => User.Surname);
        }


        [Category("Surname_Error")]
        [Description("Deve ocorrer um erro caso o campo Sobrenome Tiver menos que 3 letras")]
        [Test]
        public void Should_have_error_when_Length_Surname_is_less_than_three()
        {
            var model = new User { Surname = "Ca" };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(User => User.Surname);
        }

        [Category("Surname_Error")]
        [Description("Deve ocorrer um erro caso o campo sobrenome Tiver mais do que 50 letras")]
        [Test]
        public void Should_have_error_when_Length_Surname_is_greater_than_ten()
        {
            var model = new User { Surname = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(User => User.Surname);
        }

        [Category("Email_Error")]
        [Description("Deve ocorrer um erro caso o campo Email estiver vazio")]
        [Test]
        public void Should_have_error_when_Email_is_empty()
        {
            var model = new User { Email = "" };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(User => User.Email);
        }

        [Category("Cell_Error")]
        [Description("Deve ocorrer um erro caso o campo Cell estiver vazio")]
        [Test]
        public void Should_have_error_when_Cell_is_empty()
        {
            var model = new User { Cell = "" };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(User => User.Cell);
        }

        [Category("Cell_Error")]
        [Description("Deve ocorrer um erro caso o campo Cell tiver menos de 11 digitos")]
        [Test]
        public void Should_have_error_when_length_Cell_is_less_than_eleven()
        {
            var model = new User { Cell = "178855" };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(User => User.Cell);
        }

        [Category("IdUser_Sucess")]
        [Description("Usuario de criaçao maior que zero")]
        [Test]
        public void Should_have_ok_when_user_created_is_grester_than_zero()
        {
            var model = new User { IdUser = 1 };
            var result = validator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(User => User.IdUser);
        }

        [Category("Name_Sucess")]
        [Description("O campo Nome Deve estar devidamente preenchido")]
        [Test]
        public void Should_have_ok_when_FristName_is_filled()
        {
            var model = new User { FirstName = "Bruce" };
            var result = validator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(User => User.FirstName);
        }

        [Category("Surname_Sucess")]
        [Description("O campo Sobrenome Deve estar devidamente preenchido")]
        [Test]
        public void Should_have_ok_when_Surname_is_filled()
        {
            var model = new User { FirstName = "Wayne" };
            var result = validator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(User => User.FirstName);
        }

        [Category("Email_Sucess")]
        [Description("O campo Email deve ser devidamente preenchido")]
        [Test]
        public void Should_have_ok_when_Email_is_filled()
        {
            var model = new User { Email = "bwayne@outlook.com" };
            var result = validator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(User => User.Email);
        }

        [Category("Cell_Sucess")]
        [Description("O campo Cell deve ser devidamente preenchido")]
        [Test]
        public void Should_have_ok_when_Cell_is_filled()
        {
            var model = new User { Cell = "17988556552" };
            var result = validator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(User => User.Cell);
        }


    }

    
}