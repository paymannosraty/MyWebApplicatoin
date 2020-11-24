using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Base
{
	public abstract class Entity : object
	{
		public Entity() : base()
		{
			Id = System.Guid.NewGuid();
			InsertDateTime = DateTime.Now;
		}

		// **********
		[Key]

		[DatabaseGenerated
			(DatabaseGeneratedOption.None)]

		[Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Id))]
		public System.Guid Id { get; set; }
		// **********

		// **********
		[Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.InsertDateTime))]
		public System.DateTime InsertDateTime { get; set; }
		// **********
	}
}