using System.Collections.Generic;
using System;


namespace guardi.Data
{
    public class InMemoryDatabase
    {
       

       public static List<Article> ListOfArticles()
       {

             var listOfAllArticles = new List<Article>

            {
                //new Article{ArticleNumber=1,Date= "January 8th,2022", Title="",Subtitle="", MainBody="",,Paragraph="",ArticleType="",Photo = "vaxpass.jpg",PhotoLicence=""}
                new Article{ArticleNumber=9,Date= "January 18th,2022", Title="I’m proud that I can’t speak properly and so should all the other working class folks like me, says Angela Rayner",Subtitle="Angela Rayner, the Labour Party deputy leader has come under attack from far-right groups in recent days criticising what they claim to be her bad grammar and inability to structure sentences properly.", MainBody="‘Far-right news outlets, such as the the Daily Telegraph have been critical of the way I speak recently’ said Rayner. ‘They are scum as far as I’m concerned and it’s just picking on Northerners, our culture and the way we talk to each other’ she continued. ‘Our education system is classist and is designed to favour southerners who go to fancy schools and are taught to read and write properly’.",Paragraph="Rayner stated that ‘Its all a big tory scam. Us Northerners should not be penalised just because during exams, we write down a load of old drivel with a cheap blue biro and then get bad grades’.’Im proud that I can’t talk or write properly and so should every Northerner who lives in the North. It’s just Tory scumbags being their scummy bag selves, init’ said Rayner.",ArticleType="Politics",Photo = "angelarayner.jpeg",PhotoLicence="https://creativecommons.org/licenses/by-sa/4.0/deed.en"},
                new Article{ArticleNumber=8,Date= "January 18th,2022",Title="Face masks are likely to be in place forever and alongside the kilt will become part of our national dress, says Sturgeon",Subtitle="I Am The Ling", MainBody="info about the Ltory",ArticleType="Covid",Photo="sturgeon.jpeg",PhotoLicence="https://nationalarchives.gov.uk/doc/open-government-licence/version/1/"},
                new Article{ArticleNumber=7,Date= "January 15th,2022", Title="I am the science,anyone who disputes that, questions humanity itself, says Fauci",Subtitle="In a recent showdown on capitol hill between senators and Dr Anthony Fauci, the esteemed physician fired back at his ghastly Republican critics.", MainBody="Numerous Republican senators questioned Fauci about his involvement in the funding of Chinese gain of function research. He faced criticsm also regarding recent emails suggesting he may have been involved in smearing other scientists who disagree with him on certain matters.",Paragraph="In a withering put down, Fauci reponded by putting his critics firmly in their places. 'Firstly, i had nothing to do with any of this crap' said Fauci. 'Furthermore, you lot dont know what you are talking about, you are not a Doctor like what i am. You know jack about covid, jack about science. Let me state this categorically, I am the science and anyone who disputes that,questions humanity itself...I am the science.' said Fauci" ,ArticleType="Covid",Photo="fauci.jpeg"},
                new Article{ArticleNumber=6,Date= "January 11th,2022", Title="The definition of 'Endemic' will be changed to mean exactly the same as 'Pandemic', says Sir Vallance",Subtitle="I Am The Ling", MainBody="info about the Ltory",ArticleType="Covid",Photo="vaxpass.jpg"},
                new Article{ArticleNumber=5,Date= "January 11th,2022", Title="Selfish people are using up NHS beds by becoming ill, says Health Secretary",Subtitle="I Am The Ling", MainBody="info about the Ltory",ArticleType="Covid",Photo="vaxpass.jpg"},
                new Article{ArticleNumber=4,Date= "January 12th,2022", Title="Climate Change is caused by Systemic Racism ,Say experts.",Subtitle="Climate Change is caused by Systemic Racism ,Say experts.", MainBody="info about the sBtory",ArticleType="Climate Crisis",Photo="climate.jpg"},
                new Article{ArticleNumber=3,Date= "January 12th,2022", Title="Church Of England to be rebranded as 'Climate Mission UK',says Archbishop of Canterbury",Subtitle="Climate Change Is Caused by Racism, Expert Says.", MainBody="info about the Mtory",ArticleType="Religion",Photo="church.jpg"},
                new Article{ArticleNumber=2,Date= "January 11th,2022", Title="Fat Pass under consideration to help reduced pressure on cardiac NHS beds,says Chris Whitty ",Subtitle="I Am The Ling", MainBody="info about the Ltory",ArticleType="Covid",Photo="vaxpass.jpg"},
                new Article{ArticleNumber=1,Date= "January 8th,2022", Title="I Am the Basaddn",Subtitle="I Am Thesad Ling", MainBody="info about sadthe Ltory",ArticleType="News",Photo = "vaxpass.jpg"}

            };

            return listOfAllArticles;

       }
    }

}