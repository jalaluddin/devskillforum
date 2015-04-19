using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class AdvanceSearchEngine : ISearchEngine
{
	public virtual string SearchText
	{
		get;
		set;
	}

	public virtual DateTime PostDateTimeFrom
	{
		get;
		set;
	}

	public virtual DateTime PostDateTimeTo
	{
		get;
		set;
	}

	public virtual ICollection<Post> Search()
	{
		throw new System.NotImplementedException();
	}

}

