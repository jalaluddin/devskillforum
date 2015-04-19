using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Thread : IVotable
{
	public virtual string Title
	{
		get;
		set;
	}

	public virtual string Description
	{
		get;
		set;
	}

	public virtual bool IsSticky
	{
		get;
		set;
	}

	public virtual bool Answered
	{
		get;
		set;
	}

	public virtual DateTime CreateDateTime
	{
		get;
		set;
	}

	public virtual IUser ThreadOwner
	{
		get;
		set;
	}

	public virtual IEnumerable<Post> Posts
	{
		get;
		set;
	}

	public virtual ThreadStatus CurrentStatus
	{
		get;
		set;
	}

	public virtual void IncreaseUpVote()
	{
		throw new System.NotImplementedException();
	}

	public virtual void IncreaseDownVote()
	{
		throw new System.NotImplementedException();
	}

}

