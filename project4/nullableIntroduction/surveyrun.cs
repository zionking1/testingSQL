using System.Collections.Generic;
namespace NullableIntroduction
{
public class SurveyRun
{
private List<SurveyQuestion> surveyQuestions = new List<SurveyQuestion>();
public void AddQuestion(QuestionType type, string question) =>
AddQuestion(new SurveyQuestion(type, question));
public void AddQuestion(SurveyQuestion surveyQuestion) => surveyQuestions.Add(surveyQuestion);
}
}