using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Resources;

namespace Models
{
	public class Country : Base.Entity
	{
		public Country() : base()
		{
		}

		//**********
		[Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(ErrorMessages),
			ErrorMessageResourceName = nameof(ErrorMessages.Required))]

		[MaxLength
			(length: Models.Constant.Length.NAME,
			ErrorMessageResourceType = typeof(ErrorMessages),
			ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]

		[Display
			(ResourceType = typeof(DataDictionary),
			Name = nameof(DataDictionary.Name))]
		public string Name { get; set; }
		//**********

		//**********
		[Display
			(ResourceType = typeof(DataDictionary),
			Name = nameof(DataDictionary.Population))]
		public int Population { get; set; }
		//**********
	}
}
