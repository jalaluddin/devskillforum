using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Forum
{
	public virtual string Name
	{
		get;
		set;
	}

	public virtual string Description
	{
		get;
		set;
	}

	public virtual string TermsOfUse
	{
		get;
		set;
	}

	public virtual IEnumerable<Section> Sections
	{
		get;
		set;
	}

	public virtual void ArchiveOldPosts()
	{
		throw new System.NotImplementedException();
	}

}

