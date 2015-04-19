using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class BasicSearchEngine : ISearchEngine
{
	public virtual string SearchText
	{
		get;
		set;
	}

	public virtual ICollection<Post> Search()
	{
		throw new System.NotImplementedException();
	}

}

