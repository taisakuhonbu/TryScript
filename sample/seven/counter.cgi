#! /usr/bin/ruby

CounterFileName = "counter.txt";
DigitSystem = 7;
NumberOfDigit = 14;

CounterArgumentName = "counter_value";

def counter_output(str)
    $stdout << "Content-type: text/javascript\n\n";
    $stdout << CounterArgumentName;
    $stdout << " = \"";
    $stdout << str;
    $stdout << "\";\n";
end

strCount = "0";

begin
    fp = File::open(CounterFileName, "r");
    begin
        strCount = fp.read(NumberOfDigit);
    end
    fp.close();
rescue

end

strCount.reverse!();

while strCount.length < NumberOfDigit
    strCount << "0";
end

arrCount = Array::new();
i = 0;
begin
    arrCount << strCount[i, 1].to_i();
    i += 1;
end until i == NumberOfDigit

i = 0;
bCarry = false;
begin
    if arrCount[i] >= DigitSystem - 1
        bCarry = true;
        arrCount[i] = 0;
        i += 1;
    else
        bCarry = false;
        arrCount[i] += 1;
    end
end while bCarry

i = 0;
strCount = "";
begin
    strCount << sprintf("%d", arrCount[i]);
    i += 1;
end until i == NumberOfDigit

strCount.reverse!();

begin
    fp = File::open(CounterFileName, "w");
    begin
        fp << strCount;
    rescue
        raise();
    end
    fp.close();
rescue
    strCount = "0" * NumberOfDigit;
end

counter_output(strCount);
