using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Post : IVotable
{
	public virtual string Description
	{
		get;
		set;
	}

	public virtual DateTime CreateDateTime
	{
		get;
		set;
	}

	public virtual bool IsCorrectAnswer
	{
		get;
		set;
	}

	public virtual IUser PostOwner
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

