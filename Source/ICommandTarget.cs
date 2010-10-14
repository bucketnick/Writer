namespace Writer
{
	using System;
	using System.Collections.Specialized;
	using System.ComponentModel;

	internal interface ICommandTarget
	{
		bool Execute(CommandState commandState);
		bool QueryStatus(CommandState commandState);
	}
}