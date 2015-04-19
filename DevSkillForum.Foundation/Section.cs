using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Section
{
	public virtual string Name
	{
		get;
		set;
	}

	public virtual Guid ID
	{
		get;
		set;
	}

	public virtual int DisplayOrder
	{
		get;
		set;
	}

	public virtual DateTime CreateDateTime
	{
		get;
		set;
	}

	public virtual IEnumerable<Thread> Threads
	{
		get;
		set;
	}

	public virtual SectionState CurrentState
	{
		get;
		set;
	}

	public virtual void MarkForDelete()
	{
		throw new System.NotImplementedException();
	}

	public virtual void CreateThread(Thread thread)
	{
		throw new System.NotImplementedException();
	}

	public virtual DateTime GetDeleteCompletionDateTime()
	{
		throw new System.NotImplementedException();
	}

}

